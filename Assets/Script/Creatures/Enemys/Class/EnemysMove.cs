using Assets.Script.Creatures.Interfase;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysMove : MonoBehaviour,IMove, IInit
{
    private int _speed;
    public int Speed { get => _speed; set => _speed = value; }

    public void InitStats<T>(T t)
    {
        _speed = Convert.ToInt32(t);
    }
}
