using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiroHP : HiroControl, IHP
{
    private int _HP;
    public int HP { get => _HP; set => _HP=value; }
}
