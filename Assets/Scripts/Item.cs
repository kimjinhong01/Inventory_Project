using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public Item(string name, Type type, int value)
    {
        this.name = name;
        this.type = type;
        this.value = value;
    }
}
