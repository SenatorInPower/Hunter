using Assets.Script.Creatures.Enemys.Class;
using Assets.Script.Creatures.Interfase;
using UnityEngine;

namespace Assets.Script.Creatures.Player.HiroAtack
{
    public partial class PullLogic
    {
        private void OnEnable()
        {
            print("shut logic eneble");
        }

        public void Shut()
        {
            if (countBollShut > pull.Count-1)
            {
                countBollShut = 0;

            }
            pull[countBollShut].transform.position = atackHiro.TargetShut.position;
            pull[countBollShut].gameObject.SetActive(true);
            countBollShut++;
           
        }
        void Damage(Boll boll, EnemysAtack enemysAtack )
        {
            atackHiro.Atack(enemysAtack._HPEnemys);
            enemysAtack.AtackOut(boll.Damage);
            float Chens = Random.Range(atackHiro.ChensRandom(), 100);

            if (Chens > 98)  //if hiro hp is lou chens for move boll in next enemys is up
            {
                boll.MoveTo();
            }
            else
            {
                boll.gameObject.SetActive(false);
            }
        }

    }
}