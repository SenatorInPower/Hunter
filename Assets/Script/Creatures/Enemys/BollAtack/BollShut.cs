using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EnemysBoll
{
    public partial class BollPull : MonoBehaviour
    {
        int countBullShut;
        public void MissShut()
        {
            pull[countBullShut].MissTP();
        }
        public void Shut(Transform hiro)
        {
            countBollShut++;
            pull[countBullShut].gameObject.SetActive(true);
            pull[countBullShut].MoveToHiro(hiro);
        }
    }
}