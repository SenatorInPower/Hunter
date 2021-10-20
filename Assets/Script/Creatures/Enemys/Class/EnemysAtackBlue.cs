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
        private Action<GameObject> _TeleportHiro;
        internal BollPull BollPull;

        internal Action<GameObject> _TeleportHiro_()
        {
            if(_TeleportHiro == null)
            {
                _TeleportHiro += TeleportHiro;
            }
            return _TeleportHiro;
        }
        public void AtackAction(Action fin)
        {
          //  StartCoroutine(AtackPhase(HiroTransform,fin));
            BollPull.Shut(Control.HiroTransform);

        }

       
        //IEnumerator AtackPhase(Transform hiro,Action fin)
        //{
        //    while (true)
        //    {

        //        print("stop");
        //        fin?.Invoke();

        //        yield break;
        //    }
        //}
      

        //private void Awake()
        //{
        //    _TeleportHiro += TeleportHiro;
        //}
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