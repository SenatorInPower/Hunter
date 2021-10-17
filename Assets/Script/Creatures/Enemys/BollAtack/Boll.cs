using DG.Tweening;
using UnityEngine;
using System.Collections;
using System;
namespace EnemysBoll
{
    public class Boll : MonoBehaviour
    {
        public Func<bool, bool> stopTeleportation;
        private void OnEnable()
        {
            stopIfTeleport = false;

            stopTeleportation += StopTP;
        }
        private void OnDestroy()
        {
            stopTeleportation -= StopTP;

        }
        bool StopTP(bool stop)
        {
            return stopIfTeleport = stop;
        }
        internal bool stopIfTeleport = false;
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

        IEnumerator MoveToHiro(Transform hiro)
        {
            Transform target = hiro;
            while (true)
            {
                transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime / 3);
                if (stopIfTeleport)
                {
                    StartCoroutine(MoveIfTeleport(hiro.position));
                    yield break;
                }
            }
        }

        IEnumerator MoveIfTeleport(Vector3 moveTo)
        {
            Vector3 startMove = transform.position;
            float time = 0;
            while (true)
            {
                time += Time.deltaTime;
                transform.position = Vector3.Lerp(startMove, moveTo, time);
                if (time > 1)
                {

                    gameObject.SetActive(false);
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == ControlerLevel.NameTagHiro)
            {

                gameObject.SetActive(false);
            }
        }
    }
}