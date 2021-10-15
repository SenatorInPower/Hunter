using DG.Tweening;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Enemys.Class
{
    public class EnemysAtackBlue : EnemysAtack
    {

        void MovePatchToHiro(Transform hiroPos)
        {
            int hightFlie = UnityEngine.Random.Range(6, 10);
            transform.DOMove(ControlerLevel.RandomLevelPosition() + Vector3.up * hightFlie, 3).OnComplete(() => { StartCoroutine(ToHiro(hiroPos)); });
        }


        IEnumerator ToHiro(Transform hiroPos)
        {
            while (true)
            {
                transform.position = Vector3.Lerp(transform.position, hiroPos.position, Time.deltaTime);
                yield return null;
            }
        }
        void Dead()
        {
            print("Dead");
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == ControlerLevel.NameTagHiro)
            {
                gameObject.SetActive(false);
                Dead();
            }
        }
    }
}