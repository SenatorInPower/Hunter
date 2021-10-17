using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Atack = Assets.Script.Creatures.Player.Class;
namespace Assets.Script.Creatures.Player.HiroAtack
{
    public partial class PullLogic : SerializedMonoBehaviour
    {
        
        [SerializeField]
        private GameObject Boll;
     
        internal Atack.HiroAtack atackHiro;

        [SerializeField]
        private int BollCount = 10;

        private List<Boll> pull;
        private int countBollShut = 1;
       public  void Init()
        {
           
            pull = new List<Boll>();
            SceneManager.sceneLoaded += LoadScen;
            for (int i = 0; i < BollCount; i++)
            {
                GameObject Bools = Instantiate(Boll, atackHiro.transform);
                Boll objectBoll = Bools.GetComponent<Boll>();
                pull.Add(objectBoll);
                Bools.SetActive(false);

                objectBoll.Damage = atackHiro.DamageGive;
                objectBoll.BollCollision += Damage;

            }
        }
        //private void Awake()
        //{
        //  //  Init();
         

        //}
        public List<Boll> BollGet()
        {
            return pull;
        }
        private void LoadScen(Scene arg0, LoadSceneMode arg1)
        {

            if (pull != null)
            {
                foreach (var item in pull)
                {
                    item.GetComponent<Boll>().BollCollision -= Damage;
                }
            }

        }




    }
}