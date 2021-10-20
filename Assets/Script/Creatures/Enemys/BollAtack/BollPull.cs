using Assets.Script.Creatures.Interfase;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EnemysBoll
{
    public partial class BollPull : MonoBehaviour
    {
        [SerializeField]
        private GameObject Boll;
        internal IAtack EnemysAtack;

        [SerializeField]
        private int BollCount = 10;
        private  static int InitNum;
        private List<Boll> pull;
        private int countBollShut = 1;
        public void Init(Transform root)
        {
            GameObject pullRutEnemys = new GameObject($"pullRutEnemys {InitNum}");
            pull = new List<Boll>();
            InitNum++;
            for (int i = 0; i < BollCount; i++)
            {
                GameObject Bools = Instantiate(Boll, pullRutEnemys.transform) ; 
                Boll objectBoll = Bools.GetComponent<Boll>();
                objectBoll.EnemysAtack = EnemysAtack;
                pull.Add(objectBoll);
                Bools.SetActive(false);

            

            }
        }
        
    }
}