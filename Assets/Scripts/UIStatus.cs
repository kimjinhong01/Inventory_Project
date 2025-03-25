using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Button menuBtn;

    [SerializeField] private UIMainMenu mainMenu;

    [SerializeField] private TextMeshProUGUI hpTxt;
    [SerializeField] private TextMeshProUGUI mpTxt;

    [SerializeField] private TextMeshProUGUI atkTxt;
    [SerializeField] private TextMeshProUGUI defTxt;

    [SerializeField] private GameManager gameManager;

    private void Start()
    {
        menuBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);

        Init();
    }

    private void Init()
    {
        hpTxt.text = $"{gameManager.Player.hp}/{gameManager.Player.maxHp}";
        mpTxt.text = $"{gameManager.Player.mp}/{gameManager.Player.maxMp}";

        atkTxt.text = gameManager.Player.atk.ToString();
        defTxt.text = gameManager.Player.def.ToString();
    }
}
