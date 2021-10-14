using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHP 
{
    public Action Dead { get; set; }
    public int HP { get; set; }
    public int MaxHP { get; }

}
