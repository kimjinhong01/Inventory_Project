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

    public void Init()
    {
        hpTxt.text = $"{gameManager.Player.hp}/{gameManager.Player.maxHp}";
        mpTxt.text = $"{gameManager.Player.mp}/{gameManager.Player.maxMp}";

        atkTxt.text = gameManager.Player.atk.ToString();
        defTxt.text = gameManager.Player.def.ToString();
    }

    public void UpdateHP(int value)
    {
        hpTxt.text = $"{gameManager.Player.hp} +{value}/{gameManager.Player.maxHp}";
    }

    public void UpdateMP(int value)
    {
        mpTxt.text = $"{gameManager.Player.mp} +{value}/{gameManager.Player.maxMp}";
    }

    public void UpdateATK(int value)
    {
        atkTxt.text = $"{gameManager.Player.atk} +{value}";
    }

    public void UpdateDEF(int value)
    {
        defTxt.text = $"{gameManager.Player.def} +{value}";
    }
}
