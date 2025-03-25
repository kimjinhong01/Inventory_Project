using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;

    [SerializeField] private TextMeshProUGUI nameTxt;
    [SerializeField] private TextMeshProUGUI typeTxt;
    [SerializeField] private TextMeshProUGUI levelTxt;
    [SerializeField] private TextMeshProUGUI expTxt;

    [SerializeField] private GameManager gameManager;

    private void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);

        Init();
    }

    private void Init()
    {
        nameTxt.text = gameManager.Player.name;
        typeTxt.text = Enum.GetName(typeof(Character.Type), gameManager.Player.type);
        levelTxt.text = gameManager.Player.level.ToString();
        expTxt.text = $"{gameManager.Player.exp}/{50}";
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.Inventory.gameObject.SetActive(false);
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.MainMenu.gameObject.SetActive(true);
    }

    public void OpenStatus()
    {
        UIManager.Instance.Status.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(true);
    }
}
