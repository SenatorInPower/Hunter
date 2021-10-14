using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysHP : MonoBehaviour,IHP
{
    private int _HP;
    public int HP { get => _HP; set  { _HP = value; if (_HP < 1) { _dead.Invoke(); } }  }

    private int _MaxHP;
    public int MaxHP { get => _MaxHP; }

    private Action _dead;
    public Action Dead { get => _dead; set => _dead = value; }
}
