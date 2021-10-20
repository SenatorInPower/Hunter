using Assets.Script.Creatures.Player.HiroAtack;
using Assets.Script.ScenMeneger.UI;
using Cinemachine;
using System.Collections;
using UnityEngine;

namespace Assets.Script.ScenMeneger.Class
{
    public class Spawn : MonoBehaviour
    {

       public static Camera Camera;
        public UIAction UI;
       public SpawnEnemys SpawnEnemys;
       public SpawnHiro CriateHiro;
        
   
        
        private void Awake()
        {
            Camera = Camera.main;

            SpawnEnemys.SetUI(UI);
            CriateHiro.SetUI(UI);

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