using DG.Tweening;
using UnityEngine;
using System.Collections;
using System;
using Assets.Script.Creatures.Interfase;

namespace EnemysBoll
{
    public class Boll : MonoBehaviour
    {
        internal bool stopIfTeleport = false;
        internal IAtack EnemysAtack;
        //public Action stopTeleportation;
        //private void OnEnable()
        //{
        //    stopIfTeleport = false;

        //    stopTeleportation += StopTP;
        //}
        //private void OnDestroy()
        //{
        //    stopTeleportation -= StopTP;

        //}
       public   void MissTP()
        {
             stopIfTeleport = true;
        }
      
        private void MoveToTarget(Transform hiro, GameObject particle)
        {
            Tweener tweener = transform.DOMove(hiro.position, 3).SetSpeedBased(true);
            tweener.OnUpdate(delegate ()
            {
            // if the tween isn't close enough to the target, set the end position to the target again

            tweener.ChangeEndValue(hiro.position, true);
                if (stopIfTeleport)
                {
                    tweener.Kill();
                }

            }).OnComplete(() =>
            {

                if (stopIfTeleport)
                {

                    transform.DOMove(hiro.position, 1f).OnComplete(() =>
                    {
                        if (particle)
                        {
                            Instantiate(particle, transform);
                        }
                    });

                }


                else
                {
                    if (particle)
                    {
                        Instantiate(particle, transform);
                    }
                }


            });
        }
        public void StartMoveToHiro(Transform hiro)
        {
            StartCoroutine(MoveToHiro(hiro));
            //MoveToTarget(hiro, null);
        }

     public   IEnumerator MoveToHiro(Transform hiro)
        {
            Transform target = hiro;
            float time = 0;
            Vector3 start = transform.position;
            while (true)
            {
                time += Time.deltaTime;
                transform.position = Vector3.Lerp(start, target.position, time);
                if (stopIfTeleport)
                {
                    StartCoroutine(MoveIfTeleport(hiro.position));
                    stopIfTeleport = false;
                    yield break;
                }
                yield return null;
            }
        }

        IEnumerator MoveIfTeleport(Vector3 moveTo)
        {
           
            Vector3 startMove = transform.position;
            float time = 0;
            while (true)
            {
                time += Time.deltaTime/2;
                transform.position = Vector3.Lerp(startMove, moveTo, time);
                if (time > 1)
                {

                    gameObject.SetActive(false);
                }
                yield return null;

            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == ControlerLevel.NameTagHiro)
            {
                EnemysAtack.Atack(null);
                gameObject.SetActive(false);
            }
        }
    }
}