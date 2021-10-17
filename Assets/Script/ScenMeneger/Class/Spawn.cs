using Assets.Script.Creatures.Player.HiroAtack;
using Cinemachine;
using System.Collections;
using UnityEngine;

namespace Assets.Script.ScenMeneger.Class
{
    public class Spawn : MonoBehaviour
    {
       public SpawnEnemys SpawnEnemys;
       public SpawnHiro CriateHiro;

        public AbilityAction UITeleport;
        public AbilityAction UIUlt;
        public MoveAction MoveAction;
        public ShutAction ShutAction;
   
        
        private void Awake()
        {
            Criate();
        }
        void Criate()
        {
           
            GameObject hiro;
            CriateHiro.InitUI(UITeleport, UIUlt,MoveAction, ShutAction);
            CriateHiro.HiroCreate(out hiro);
            CriateHiro.InitCamera(hiro.transform);

            MoveAction.Hiro = hiro.transform;


            SpawnEnemys.EnemysCriate(hiro.transform);
            SpawnEnemys.InitUI(UIUlt);
        }
        private void OnDisable()
        {
            UITeleport.action = null;
            UIUlt.action = null;
        }
    }
}