using UnityEngine;

namespace Assets.Script.Creatures.Player.HiroAtack
{
    public partial class PullLogic
    {
        public void Shut()
        {
            pull[countBollShut].transform.position = atackHiro.TargetShut.position;
            pull[countBollShut].gameObject.SetActive(true);
            countBollShut++;
            if (countBollShut > pull.Count)
            {
                countBollShut = 0;
                
            }
        }
        void Damage(IHP hp,Boll boll )
        {
            atackHiro.Atack(hp);
            float Chens = UnityEngine.Random.Range(atackHiro.ChensRandom(), 100);

            if (Chens > 98)
            {
               // boll.MoveTo()
            }
            else
            {
                boll.gameObject.SetActive(false);
            }
        }

    }
}