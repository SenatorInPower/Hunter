using Assets.Script.Creatures.Interfase;
using DG.Tweening;
using System;
using UnityEngine;
namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroMove : HiroControl, IMove
    {

        public CapsuleCollider Collider;
        internal Action<GameObject> Teleportation;

        private void OnEnable()
        {
            Teleportation += MoveToTeleportation;
        }
        private void OnDisable()
        {
            Teleportation -= MoveToTeleportation;

        }

        private int _speed;
        public int Speed { get => _speed; set => _speed = value; }



        public override void InitStats<T>(T speed)
        {
            _speed = Convert.ToInt32(speed);


        }
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
        void MoveToTeleportation(GameObject particle)
        {
            if (particle != null)
            {
                Vector3 moveTo = gameObject.transform.position + Vector3.forward * 5;
                transform.DOMove(moveTo, 1);
            }
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == ControlerLevel.NameTagEnemys)
            {

            }
            else if (other.tag == ControlerLevel.NameTagArea)
            {
                transform.position = ControlerLevel.RandomLevelPosition();
            }
        }
    }
}