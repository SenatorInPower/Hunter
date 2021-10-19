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
            int hightFlie = UnityEngine.Random.Range(1, 3);
            Sequence twin = DOTween.Sequence();
            Vector3 moveUp = ControlerLevel.RandomLevelPosition(transform.position) + Vector3.up * hightFlie;
            twin.Append(transform.DOMove(moveUp, 3))/*.AppendInterval(1)*/.OnComplete(() => { inAir = transform.position; StartCoroutine(ToHiro(hiroPos)); });
            print(moveUp);
        }
        Vector3 inAir;
        IEnumerator ToHiro(Transform hiroPos)
        {
            float time = 0;
            float distTime = Vector3.Distance(inAir, hiroPos.position) / 10;
            float timeDist = Mathf.Lerp(2, 4, distTime);
            while (true)
            {
                time += Time.deltaTime/ timeDist;
                transform.position = Vector3.Lerp(inAir, hiroPos.position, time);
                if (time > 1)
                {
                    yield break;
                }
                yield return null;
            }
        }

    }
}