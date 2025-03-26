using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Character player;
    public Character Player { get { return player; } }

    public ItemData[] items;

    public GameManager()
    {
        player = new Character("Michael", Character.Type.Archer);
    }

    private void Start()
    {
        for (int i = 0; i < items.Length; i++)
            UIManager.Instance.Inventory.AddItem(items[i]);
    }
}
