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
        const int SpeedBoll = 10;
        internal int Damage;
        internal Action<IHP,Boll> BollCollision;
        const string EnemysTag = "Enemys";

        public void MoveTo(List<GameObject> enemys)
        {
            Transform moveToTransform = SpawnEnemys.AtackNearestBlue(transform.position);
            StartCoroutine(_MoveTo(moveToTransform));
        }
      
        IEnumerator _MoveTo(Transform to)
        {
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
                BollCollision.Invoke(collision.gameObject.GetComponent<IHP>(),this);
                collision.gameObject.GetComponent<EnemysAtack>().AtackOut(Damage);
            }
        }
        private void OnEnable()
        {

        }
        private void OnDisable()
        {

        }
        private void Update()
        {
            transform.Translate(Vector3.forward * Time.deltaTime* SpeedBoll);
        }
    }

}