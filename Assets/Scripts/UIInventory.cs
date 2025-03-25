using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button menuBtn;
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotsParent;
    private List<UISlot> slots;

    public GameObject equipButton;

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
        }
    }

    public void SetItem(Sprite background, Sprite icon, int count)
    {
        foreach (var slot in slots)
        {
            slot.SetItem(background, icon, count);
        }
    }
}
