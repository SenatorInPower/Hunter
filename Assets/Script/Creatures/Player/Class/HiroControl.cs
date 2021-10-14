using UnityEngine;
using static SpawnHiro;
namespace Assets.Script.Creatures.Player.Class
{
    public abstract class HiroControl : MonoBehaviour
    {

        public abstract void InitStats<T>(T t);
        //private HiroHP hiroHP;
        //private HiroMove hiroMove;
        //private HiroAtack hiroAtack;



        internal static void InitHiro(GameObject obj, Stats hiroStats)
        {


            obj.AddComponent<HiroMove>().InitStats(hiroStats.Speed);
            obj.AddComponent<HiroHP>().InitStats(hiroStats.HP);
            obj.AddComponent<HiroEnergy>().InitStats(hiroStats.Energy);
            obj.AddComponent<HiroAtack>().InitStats(hiroStats.Demage);



        }

        //public  Transform  HiroPos()
        //{
        //    return transform;
        //}
        //protected HiroHP HiroHP()
        //{
        //    return hiroHP;
        //}
        //protected HiroMove HiroMove()s
        //{
        //    return hiroMove;
        //}
        //protected HiroAtack HiroAttack()
        //{
        //    return hiroAtack;
        //}
    }
}