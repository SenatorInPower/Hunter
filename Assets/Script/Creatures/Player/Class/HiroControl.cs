using Assets.Script.Creatures.Interfase;
using UnityEngine;

namespace Assets.Script.Creatures.Player.Class
{
    public abstract class HiroControl : MonoBehaviour
    {

        public abstract void InitStats<T>(T t);
        //private HiroHP hiroHP;
        //private HiroMove hiroMove;
        //private HiroAtack hiroAtack;
        protected static IAtack _AtackHiro;
        protected static IMove _MoveHiro;
        protected static IHP _HPHiro;
        protected static IEnergy _EnergyHiro;

        //internal IMove IMoveGet()
        //{
        //    return gameObject.GetComponent<IMove>();
        //}
        //internal IHP IHPGet()
        //{
        //    return gameObject.GetComponent<IHP>();
        //}
        //internal IEnergy IEnergyGet()
        //{
        //    return gameObject.GetComponent<IEnergy>();
        //}
        //static IAtack IAtackGet()
        //{
        //    return GetComponent<IAtack>();
        //}


        internal static void InitHiro(GameObject obj, StatsHiro hiroStats)
        {


            HiroMove hiroMove = obj.AddComponent<HiroMove>();
            hiroMove.InitStats(hiroStats.Speed);           
            _MoveHiro = hiroMove;
            hiroMove.Teleportation = hiroStats.Teleport;

            HiroHP hiroHP = obj.AddComponent<HiroHP>();
            hiroHP.InitStats(hiroStats.HP);
            _HPHiro = hiroHP;

            HiroEnergy hiroEnergy = obj.AddComponent<HiroEnergy>();
            hiroEnergy.InitStats(hiroStats.Energy);
            _EnergyHiro = hiroEnergy;
            hiroEnergy.Ultimate = hiroStats.Ultimate ;

            HiroAtack hiroAtack = obj.AddComponent<HiroAtack>();
            hiroAtack.InitStats(hiroStats.Demage);
            _AtackHiro = hiroAtack;
            

        }

       
    }
}