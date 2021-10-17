using DG.Tweening;
using Sirenix.OdinInspector;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Enemys.Class
{
    public class EnemysMoveBlue : EnemysMove
    {




        [Button]
     public   void Move()
        {
            StartCoroutine(MovePhase());
        }
        void MoveToRendomPosRadius(int time)
        {
            transform.DOMove(ControlerLevel.RandomLevelPosition(), time);
        }

       
        IEnumerator MovePhase()
        {
            while (true)
            {
                MoveToRendomPosRadius(3);
                yield return new WaitForSeconds(3);
                _AtackAction.AtackAction();

                print("gg");
            }
        }



    }
}