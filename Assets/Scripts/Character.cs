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
    public int oldHP { get; private set; }
    public int maxHp { get; private set; }
    public int mp { get; private set; }
    public int oldMP { get; private set; }
    public int maxMp { get; private set; }

    public int atk { get; private set; }
    public int oldAtk { get; private set; }
    public int def { get; private set; }
    public int oldDef { get; private set; }


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
    }

    public void ExtraHealth(int value)
    {
        oldHP = hp;
        hp += value;
    }

    public void ExtraMP(int value)
    {
        oldMP = mp;
        mp += value;
    }

    public void ExtraATK(int value)
    {
        oldAtk = atk;
        atk += value;
    }

    public void ExtraDEF(int value)
    {
        oldDef = def;
        def += value;
    }
}
