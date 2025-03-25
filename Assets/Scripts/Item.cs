using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public enum Type
    {
        Weapon,
        Armor,
        Item
    }

    public string name { get; private set; }
    public Type type { get; private set; }
    public int value { get; private set; }

    public Sprite background;
    public Sprite icon;

    public Item(string name, Type type, int value, Sprite background, Sprite icon)
    {
        this.name = name;
        this.type = type;
        this.value = value;
        this.background = background;
        this.icon = icon;
    }
}
