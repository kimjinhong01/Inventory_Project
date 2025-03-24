using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    private void Start()
    {
        menuBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);

        Init();
    }

    private void Init()
    {
        hpTxt.text = $"{mainMenu.Player.hp}/{mainMenu.Player.maxHp}";
        mpTxt.text = $"{mainMenu.Player.mp}/{mainMenu.Player.maxMp}";

        atkTxt.text = mainMenu.Player.atk.ToString();
        defTxt.text = mainMenu.Player.def.ToString();
    }
}
