using Assets.Script.Creatures.Enemys.Class;
using Assets.Script.Creatures.Interfase;
using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Script.Creatures.Player.HiroAtack
{
    public class Boll : MonoBehaviour
    {
        const string EnemysTag = "Enemys";
        const int SpeedBoll = 10;
        internal int Damage;
        internal Action<Boll,EnemysAtack> BollCollision;

        private bool _stopMoveUpdate = false;
        public void MoveTo()
        {
            Transform moveToTransform = SpawnEnemys.AtackNearestBlue(transform.position);
            StartCoroutine(_MoveTo(moveToTransform));
        }
      
        IEnumerator _MoveTo(Transform to)
        {
            _stopMoveUpdate = true;
            while (true)
            {
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, to.position, Time.deltaTime);

                yield return null;
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == EnemysTag)
            {
                BollCollision.Invoke(this, collision.gameObject.GetComponent<EnemysAtack>());
               
            }
        }
        private void OnEnable()
        {
            _stopMoveUpdate = false;
        }
        private void OnDisable()
        {

        }
        private void Update()
        {
            if(_stopMoveUpdate == false)
            transform.Translate(Vector3.forward * Time.deltaTime* SpeedBoll);
        }
    }

}