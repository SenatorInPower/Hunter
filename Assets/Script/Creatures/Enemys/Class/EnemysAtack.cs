using Assets.Script.Creatures.Interfase;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class EnemysAtack : MonoBehaviour,IAtack,IDamage, IInit
{
    internal  IHP EnemysHP;
    private int _damage;
    public int DamageGive { get => _damage; set => _damage = value; }
   // internal IID _ID;

    public void Atack(IHP hiroHp)
    {
        
    }

    public void AtackOut(int damage)
    {
        EnemysHP.HP -= damage;
    }

    public void InitStats<T>(T t)
    {
        _damage = Convert.ToInt32(t);

    }
    public   void Ultimate()
    {
        EnemysHP.HP = 0;
        EnemysHP.Dead.Invoke();
    }
}
