using Assets.Script.Creatures.Interfase;
using EnemysBoll;
using UnityEngine;

namespace Assets.Script.Creatures.Player.HiroAtack
{
    public partial class PullLogic
    {
        private Boll navBolControler;
       

        public void Shut()
        {
            if (countBollShut > pull.Count - 1)
            {
                countBollShut = 0;

            }
            pull[countBollShut].transform.position = atackHiro.TargetShut.position;
            pull[countBollShut].gameObject.SetActive(true);
            countBollShut++;

        }
        void Damage(Boll boll, IAtack enemysAtack)
        {
            atackHiro.Atack(null);
            navBolControler = boll;
            enemysAtack.AtackOut(boll.Damage,  BoolMoveIFEnemysDead);
           
        }
     
        void BoolMoveIFEnemysDead(bool dead)
        {
            if (dead)
            {
                float Chens = Random.Range(atackHiro.ChensRandom(), 100);

                if (Chens > 30)  //if hiro hp is lou chens for move boll in next enemys is up
                {
                    navBolControler.MoveTo();
                }
                else
                {
                    navBolControler.gameObject.SetActive(false);
                }
            }
            else
            {
                navBolControler.gameObject.SetActive(false);
            }
        }

    }
}