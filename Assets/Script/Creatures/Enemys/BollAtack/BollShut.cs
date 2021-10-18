using Assets.Script.Creatures.Interfase;
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
            pull[countBullShut].transform.position = transform.position;
            countBollShut++;
            pull[countBullShut].gameObject.SetActive(true);
            pull[countBullShut].StartMoveToHiro(hiro);
        }
    }
}