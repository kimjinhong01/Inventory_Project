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

    public string name;
    public Type type;
    public int level;
    public int exp;

    public int hp;
    public int maxHp;
    public int mp;
    public int maxMp;

    public int atk;
    public int def;
    
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
}
