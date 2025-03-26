using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public GameManager manager;

    public List<UISlot> slots;

    public Button menuBtn;

    public Transform slotsParent;

    public GameObject equipButton;
    public GameObject unequipButton;

    ItemData selectedItem;
    int selectedItemIndex = 0;

    int curEquipIndex;

    private void Start()
    {
        menuBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);

        slots = new List<UISlot>(new UISlot[slotsParent.childCount]);

        for (int i = 0; i < slots.Count; i++)
        {
            slots[i] = slotsParent.GetChild(i).GetComponent<UISlot>();
            slots[i].index = i;
            slots[i].inventory = this;
        }

        equipButton.SetActive(false);
        unequipButton.SetActive(false);
    }

    public void AddItem(ItemData data)
    {
        if (data.canStack)
        {
            UISlot slot = GetItemStack(data);
            if (slot != null)
            {
                slot.quantity++;
                UpdateUI();
                return;
            }
        }

        UISlot emptySlot = GetEmptySlot();

        if (emptySlot != null)
        {
            emptySlot.item = data;
            emptySlot.quantity = 1;
            UpdateUI();
            return;
        }
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].item != null)
            {
                slots[i].Set();
            }
            else
            {
                slots[i].Clear();
            }
        }
    }

    UISlot GetItemStack(ItemData data)
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].item == data && slots[i].quantity < data.maxStackAmount)
            {
                return slots[i];
            }
        }
        return null;
    }

    UISlot GetEmptySlot()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].item == null)
            {
                return slots[i];
            }
        }
        return null;
    }

    public void SelectItem(int index)
    {
        if (slots[index].item == null) return;

        selectedItem = slots[index].item;
        selectedItemIndex = index;

        equipButton.SetActive(selectedItem.type == ItemType.Equipable && !slots[index].equipped);
        unequipButton.SetActive(selectedItem.type == ItemType.Equipable && slots[index].equipped);
    }

    public void OnEquipButton()
    {
        if (slots[curEquipIndex].equipped)
        {
            UnEquip(curEquipIndex);
        }

        slots[selectedItemIndex].equipped = true;
        curEquipIndex = selectedItemIndex;
        UpdateUI();

        SelectItem(selectedItemIndex);

        for (int i = 0; i < slots[curEquipIndex].item.consumables.Length; i++)
        {
            switch (slots[curEquipIndex].item.consumables[i].type)
            {
                case ConsumableType.Health:
                    manager.Player.ExtraHealth(slots[curEquipIndex].item.consumables[i].value);
                    UIManager.Instance.Status.UpdateHP(slots[curEquipIndex].item.consumables[i].value);
                    break;
                case ConsumableType.MP:
                    manager.Player.ExtraMP(slots[curEquipIndex].item.consumables[i].value);
                    UIManager.Instance.Status.UpdateMP(slots[curEquipIndex].item.consumables[i].value);
                    break;
                case ConsumableType.ATK:
                    manager.Player.ExtraATK(slots[curEquipIndex].item.consumables[i].value);
                    UIManager.Instance.Status.UpdateATK(slots[curEquipIndex].item.consumables[i].value);
                    break;
                case ConsumableType.DEF:
                    manager.Player.ExtraDEF(slots[curEquipIndex].item.consumables[i].value);
                    UIManager.Instance.Status.UpdateDEF(slots[curEquipIndex].item.consumables[i].value);
                    break;
            }
        }
    }

    public void OnUnEquipButton()
    {
        UnEquip(selectedItemIndex);
    }

    void UnEquip(int index)
    {
        slots[index].equipped = false;
        UpdateUI();

        if (selectedItemIndex == index)
        {
            SelectItem(selectedItemIndex);
        }
    }
}
