using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public List<UISlot> slots;

    public Button menuBtn;
    public GameObject slotPrefab;
    public Transform slotsParent;

    public GameObject equipButton;
    public GameObject unequipButton;

    ItemData selectedItem;
    int selectedItemIndex = 0;

    private void Start()
    {
        menuBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
        slots = new List<UISlot>();
        InitInventoryUI();
    }

    private void InitInventoryUI()
    {
        for (int i = 0; i < 42; i++)
        {
            GameObject slot = Instantiate(slotPrefab, slotsParent);
            slots.Add(slot.GetComponent<UISlot>());
            slots[i].index = i;
            slots[i].inventory = this;
        }

        equipButton.SetActive(false);
        unequipButton.SetActive(false);
    }

    public void SetItem()
    {

    }
}
