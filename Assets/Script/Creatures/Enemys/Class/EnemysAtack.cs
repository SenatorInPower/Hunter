using Assets.Script.Creatures.Interfase;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Script.Creatures.Enemys.Class
{
    public abstract class EnemysAtack : EnemysControl, IAtack, IDamage, IInit
    {

      
        private int _damage;
        public int DamageGive { get => _damage; set => _damage = value; }
        // internal IID _ID;
        private void Awake()
        {
            CapsuleCollider Collider;
            Collider = gameObject.GetComponent<CapsuleCollider>();

            if (Collider == null)
            {
                gameObject.AddComponent<CapsuleCollider>().isTrigger = true;
                Collider = gameObject.GetComponent<CapsuleCollider>();
            }
            Collider.isTrigger = true;
        }

        public void Atack(IHP hiroHp)
        {

        }

      

        public void AtackOut(int damage)
        {
            _HPEnemys.HP -= damage;
           
        }

        public void InitStats<T>(T t)
        {
            _damage = Convert.ToInt32(t);

        }

     



    }
}