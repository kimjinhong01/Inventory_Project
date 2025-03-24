using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button menuBtn;

    private void Start()
    {
        menuBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
    }
}
