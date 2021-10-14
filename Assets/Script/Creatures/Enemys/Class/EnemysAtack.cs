using Assets.Script.Creatures.Interfase;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysAtack : MonoBehaviour,IAtack,IDamage, IInit
{
    private int _damage;
    public int DamageGive { get => _damage; set => _damage = value; }

    public void Atack(IHP enemysHp)
    {
        
    }

    public void AtackOut()
    {
        
    }

    public void InitStats<T>(T t)
    {
        _damage = Convert.ToInt32(t);

    }
}
