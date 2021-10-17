using Assets.Script.Creatures.Player.HiroAtack;
using Cinemachine;
using System.Collections;
using UnityEngine;

namespace Assets.Script.ScenMeneger.Class
{
    public class Spawn : MonoBehaviour
    {
       public static Camera Camera;
       public SpawnEnemys SpawnEnemys;
       public SpawnHiro CriateHiro;
        
   
        
        private void Awake()
        {
            Camera = Camera.main;
            Criate();
        }
        void Criate()
        {
           
            GameObject hiro;
           // CriateHiro.InitUI(UITeleport, UIUlt,MoveAction, ShutAction);
            CriateHiro.HiroCreate(out hiro);
            CriateHiro.InitCamera(hiro.transform);

        //    MoveAction.Hiro = hiro.transform;


            SpawnEnemys.EnemysCriate(hiro.transform);
         //   SpawnEnemys.InitUI(UIUlt);
        }
        private void OnDisable()
        {
            //UITeleport.action = null;
            //UIUlt.action = null;
        }
    }
}