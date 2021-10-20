using Assets.Script.Creatures.Enemys.Class;
using Assets.Script.Creatures.Interfase;
using Assets.Script.ScenMeneger.Class;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Player.HiroAtack
{
    public class Boll : MonoBehaviour
    {
        public GameObject particleExplou;
        const string EnemysTag = "Enemys";
        const int SpeedBoll = 10;
      
        internal int Damage;
        internal Action<Boll, IAtack> BollCollision;
        Rigidbody _rigidbody;

        private bool _stopMoveUpdate = false;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        public void MoveTo()
        {
            Transform moveToTransform = SpawnEnemys.AtackNearestBlue(transform.position);

            if(moveToTransform)
            StartCoroutine(_MoveTo(moveToTransform));
        }

        IEnumerator _MoveTo(Transform to)
        {
            _rigidbody.isKinematic = true;
            float time = 0;
            _stopMoveUpdate = true;
            while (true)
            {
                time += Time.deltaTime / 3;
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, to.position, time);
                if (time > 1|| to.gameObject.activeSelf==false)
                {
                    _rigidbody.isKinematic = false;
                    gameObject.SetActive(false);
                    yield break;
                }
                yield return null;
            }
        }
        //private void OnCollisionEnter(Collision collision)
        //{
        //}
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == EnemysTag)
            {
                BollCollision.Invoke(this, other.gameObject.GetComponent<IAtack>());

            }
        }
        private void OnEnable()
        {
           
            Shut();
         //   _stopMoveUpdate = false;


        }
        private void OnDisable()
        {

        }
        private void Shut()
        {
            Vector3 forwardShutVector;
            forwardShutVector = transform.position;
            forwardShutVector = (forwardShutVector - Spawn.Camera.transform.position).normalized;
            _rigidbody.isKinematic = true;
            _rigidbody.isKinematic = false;
            _rigidbody.AddForce(forwardShutVector * 20, ForceMode.Impulse);
           
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.tag == ControlerLevel.NameTagArea)
            {
                Invoke("Deactiv", 3);
            }
            else
            {
                //if (other.tag == ControlerLevel.NameTagEnemys)
                //{
                //    if (particleExplou)
                //        Instantiate(particleExplou, transform);

                //    other.GetComponent<IAtack>().AtackOut(Damage);
                //}

            }
        }
        void Deactiv()
        {
            if (particleExplou)
              Instantiate(particleExplou, transform);

            gameObject.SetActive(false);
        }
    }


}