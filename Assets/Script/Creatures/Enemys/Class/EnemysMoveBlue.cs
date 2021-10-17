using DG.Tweening;
using Sirenix.OdinInspector;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Enemys.Class
{
    public class EnemysMoveBlue : EnemysMove
    {


        void MoveToRendomPosRadius(int time)
        {
            transform.DOMove(ControlerLevel.RandomLevelPosition(), time);
        }
        void Atack(Transform hiro, GameObject prefab)
        {

        }
        [Button]
        void starterTest()
        {
            StartCoroutine(PatchLoop());
        }
        Transform moveTo;
        IEnumerator PatchLoop()
        {
            while (true)
            {
                MoveToRendomPosRadius(3);
                yield return new WaitForSeconds(3);
                //  yield return new WaitForSeconds(3);
                yield return StartCoroutine(AtackLoop(HiroTransform));
                print("gg");
            }
        }
        IEnumerator AtackLoop(Transform hiro)
        {
            while (true)
            {
             
                print("stop");
                yield break;
            }
        }
    }
}