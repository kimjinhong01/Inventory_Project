using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                return null;
            }
            return instance;
        }
    }

    [SerializeField] private GameObject menuUI;
    [SerializeField] private GameObject statusUI;
    [SerializeField] private GameObject inventoryUI;

    public UIMainMenu MainMenu { get; set; }
    public UIStatus Status { get; set; }
    public UIInventory Inventory { get; set; }


}
