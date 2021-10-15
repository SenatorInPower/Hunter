using Assets.Script.Creatures.Interfase;
using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;
namespace Assets.Script.Creatures.Enemys.Class
{
    public abstract class EnemysMove : EnemysControl, IMove, IInit
    {

        protected CapsuleCollider Collider;
        private int _speed;
        public int Speed { get => _speed; set => _speed = value; }
        //internal IID _ID;

        private void Awake()
        {
            Collider = gameObject.GetComponent<CapsuleCollider>();

            if (Collider == null)
            {
                gameObject.AddComponent<CapsuleCollider>().isTrigger = true;
                Collider = gameObject.GetComponent<CapsuleCollider>();
            }
            Collider.isTrigger = true;
        }




        public void InitStats<T>(T t)
        {
            _speed = Convert.ToInt32(t);
        }
    }
}