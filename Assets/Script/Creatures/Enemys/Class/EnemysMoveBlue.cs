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
            Move();
        }

        [Button]
        public void Move()
        {
            StartCoroutine(MovePhase());
        }
        void MoveToRendomPosRadius(int time)
        {
            Vector3 to = ControlerLevel.RandomLevelPosition(transform.position);
            float distTime = Vector3.Distance(transform.position, to);
            distTime = Mathf.Lerp(0, 10, distTime / 10);
            

            transform.DOMove(to, distTime);
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