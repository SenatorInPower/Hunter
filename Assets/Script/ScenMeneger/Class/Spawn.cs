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
        private void Awake()
        {
            Criate();
        }
        void Criate()
        {
            GameObject hiro;
            CriateHiro.InitUI(UITeleport, UIUlt);
            CriateHiro.HiroCreate(out hiro);

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