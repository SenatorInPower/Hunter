using DG.Tweening;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Enemys.Class
{
    public class EnemysMoveRed : EnemysMove
    {
        private void OnEnable()
        {
            MovePatchToHiro(Control.HiroTransform) ;
        }
        internal void MovePatchToHiro(Transform hiroPos)
        {
            int hightFlie = UnityEngine.Random.Range(6, 10);
            Sequence twin = DOTween.Sequence();

            twin.Append(transform.DOMove(ControlerLevel.RandomLevelPosition() + Vector3.up * hightFlie, 3)).AppendInterval(2).OnComplete(() => { StartCoroutine(ToHiro(hiroPos)); });
        }

        IEnumerator ToHiro(Transform hiroPos)
        {
            while (true)
            {
                transform.position = Vector3.Lerp(transform.position, hiroPos.position, Time.deltaTime);
                yield return null;
            }
        }

    }
}