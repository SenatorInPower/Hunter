using Assets.Script.Creatures.Interfase;
using DG.Tweening;
using System;
using UnityEngine;
namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroMove : HiroControl, IMove
    {
        internal Action<GameObject> Teleportation;
        private CapsuleCollider Collider;


        private void OnDestroy()
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
            Teleportation += MoveToTeleportation;
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
                Instantiate(particle, transform);
               
            }
            Vector3 moveTo = gameObject.transform.position + transform.forward * 5;
            transform.DOMove(moveTo, 1);
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.tag == ControlerLevel.NameTagArea)
            {
                Vector3 posHiroTeleport= ControlerLevel.RandomLevelPosition();
                transform.position = posHiroTeleport;
            //    print(posHiroTeleport);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == ControlerLevel.NameTagEnemys)
            {

            }
        }

      
    }
}