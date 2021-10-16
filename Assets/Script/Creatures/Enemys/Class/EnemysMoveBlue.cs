using DG.Tweening;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Enemys.Class
{
    public class EnemysMoveBlue : EnemysMove
    {
      

        void MovePatch()
        {
            int hightFlie = UnityEngine.Random.Range(6, 10);
            Sequence twin = DOTween.Sequence();

            twin.Append(transform.DOMove(ControlerLevel.RandomLevelPosition() + Vector3.up * hightFlie, 3) );
            
        }
    }
}