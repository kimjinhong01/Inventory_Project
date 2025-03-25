using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Character player;
    public Character Player { get { return player; } }

    public GameManager()
    {
        player = new Character("Michael", Character.Type.Archer);
    }

    public void SetData(Character player)
    {
        this.player = player;
    }
}
