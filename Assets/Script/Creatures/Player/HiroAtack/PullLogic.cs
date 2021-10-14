using Assets.Script.Creatures.Player.Class;
using Sirenix.OdinInspector;
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
        [SerializeField]
        private Atack.HiroAtack atackHiro;
        [SerializeField]
        private int BollCount = 10;
        [SerializeField]
        private List<GameObject> pull;
        private void Awake()
        {
            SceneManager.sceneLoaded += LoadScen;
            for (int i = 0; i < BollCount; i++)
            {
                GameObject Bools = Instantiate(Boll, atackHiro.transform);
                pull.Add(Bools);
                Bools.SetActive(false);
                Boll objectBoll = Bools.GetComponent<Boll>();
                objectBoll.Damage = atackHiro.DamageGive;
                objectBoll.BollCollision += Damage;

            }

        }
        public List<GameObject> BollGet()
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