using Assets.Script.Creatures.Interfase;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiroMove : HiroControl,IMove
{
    private int  _speed;
    public int Speed { get => _speed; set => _speed=value; }


}
