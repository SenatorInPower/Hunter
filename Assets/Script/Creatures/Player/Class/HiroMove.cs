using Assets.Script.Creatures.Interfase;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroMove : HiroControl, IMove
    {

        public CapsuleCollider Collider;
        internal Teleportation Teleportation;
        const string NameTagEnemys="Enemys";
        private int _speed;
        public int Speed { get => _speed; set => _speed = value; }



        public override void InitStats<T>(T speed)
        {
            _speed = Convert.ToInt32(speed);

            
        }
        private void Awake()
        {
            Collider = gameObject.GetComponent<CapsuleCollider>();
           
            if(Collider == null)
            {
                gameObject.AddComponent<CapsuleCollider>().isTrigger = true;
                Collider = gameObject.GetComponent<CapsuleCollider>();
            }
            Collider.isTrigger = true;
        }
       
     
        private void OnTriggerEnter(Collider other)
        {
            if(other.tag== NameTagEnemys)
            {

            }
        }
    }
}