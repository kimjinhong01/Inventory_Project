using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Character player;
    public Character Player { get { return player; } }

    public Sprite[] backgrounds;
    public Sprite[] icons;

    public GameManager()
    {
        player = new Character("Michael", Character.Type.Archer);
    }

    public void SetData(Character player)
    {
        this.player = player;
        this.player.AddItem("Ä®", Item.Type.Weapon, 10, backgrounds[0], icons[0]);
        this.player.AddItem("°©¿Ê", Item.Type.Armor, 15, backgrounds[1], icons[1]);
        this.player.AddItem("À½½Ä", Item.Type.Item, 5, backgrounds[2], icons[2]);
    }
}
