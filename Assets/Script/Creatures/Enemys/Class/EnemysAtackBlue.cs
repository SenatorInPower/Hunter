using Assets.Script.Creatures.Interfase;
using DG.Tweening;
using EnemysBoll;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Enemys.Class
{ //атака перенесена в enemysmoveblue из за связи атаки с движением
    public class EnemysAtackBlue : EnemysAtack, IAtackAction
    {
        internal Action<GameObject> _TeleportHiro;
        internal BollPull BollPull;

        public void Atack()
        {
            StartCoroutine(AtackPhase(_HiroTransform.HiroTransform));
        }

        public void AtackAction()
        {
            Atack();

        }
        IEnumerator AtackPhase(Transform hiro)
        {
            while (true)
            {

                print("stop");
                yield break;
            }
        }
      

        private void Awake()
        {
            _TeleportHiro += TeleportHiro;
        }
        private void OnDestroy()
        {
            _TeleportHiro -= TeleportHiro;

        }
        void TeleportHiro(GameObject particle)
        {
            BollPull.MissShut();
        }

    }
}