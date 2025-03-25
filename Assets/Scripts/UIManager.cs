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

    [SerializeField] private UIMainMenu mainMenu;
    [SerializeField] private UIStatus status;
    [SerializeField] private UIInventory inventory;

    public UIMainMenu MainMenu { get { return mainMenu; } }
    public UIStatus Status { get { return status; } }
    public UIInventory Inventory { get { return inventory; } }
}
