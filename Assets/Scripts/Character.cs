using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum Type
    {
        Warrior,
        Archer,
        Mage
    }

    public string name { get; private set; }
    public Type type { get; private set; }
    public int level { get; private set; }
    public int exp { get; private set; }

    public int hp { get; private set; }
    public int maxHp { get; private set; }
    public int mp { get; private set; }
    public int maxMp { get; private set; }

    public int atk { get; private set; }
    public int def { get; private set; }

    private List<Item> inventory;

    private void Start()
    {
        inventory = new List<Item>();
    }

    public Character(string name, Type type)
    {
        this.name = name;
        this.type = type;
        level = 1;
        exp = 0;

        switch (type)
        {
            case Type.Warrior:
                maxHp = 120;
                hp = maxHp;
                maxMp = 30;
                mp = maxMp;
                atk = 20;
                def = 20;
                break;
            case Type.Archer:
                maxHp = 100;
                hp = maxHp;
                maxMp = 50;
                mp = maxMp;
                atk = 30;
                def = 10;
                break;
            case Type.Mage:
                maxHp = 40;
                hp = maxHp;
                maxMp = 150;
                mp = maxMp;
                atk = 10;
                def = 0;
                break;
        }

        inventory.Add(new Item("Ä®", Item.Type.Weapon, 10));
        inventory.Add(new Item("°©¿Ê", Item.Type.Armor, 15));
        inventory.Add(new Item("À½½Ä", Item.Type.Item, 5));
    }

    public void AddItem(string name, Item.Type type, int value)
    {
        inventory.Add(new Item(name, type, value));
    }

    public void Equip(int index)
    {
        // ÀåÂø
    }

    public void UnEquip()
    {

    }
}
