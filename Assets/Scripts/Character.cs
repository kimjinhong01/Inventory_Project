using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private string name;
    private int level;
    private int exp;

    private Character(string name)
    {
        this.name = name;
        level = 1;
        exp = 0;
    }
}
