using DG.Tweening;
using Sirenix.OdinInspector;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Enemys.Class
{
    public class EnemysMoveBlue : EnemysMove
    {

        WaitForSeconds waitAtack => new WaitForSeconds(2);
        WaitForSeconds waitMove => new WaitForSeconds(1);
        private void OnEnable()
        {
            MovePhase();
        }

        [Button]
        public void Move()
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
                yield return waitAtack;
                Control.AtackAction().AtackAction(null);
                yield return waitMove;

            }
        }



    }
}