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

  
        [SerializeField]
        private int BollCount = 10;

        private List<Boll> pull;
        private int countBollShut = 1;
        public void Init(Transform root)
        {

            pull = new List<Boll>();
       
            for (int i = 0; i < BollCount; i++)
            {
                GameObject Bools = Instantiate(Boll, root); 
                Boll objectBoll = Bools.GetComponent<Boll>();
                pull.Add(objectBoll);
                Bools.SetActive(false);

            

            }
        }
        
    }
}