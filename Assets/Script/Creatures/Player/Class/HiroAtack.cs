using Assets.Script.Creatures.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroAtack : HiroControl, IAtack, IDamage
    {
        internal UnityAction ShutHiro;
        internal IEnergy Energy;
        internal Transform TargetShut;

        [SerializeField]
        private int _damage;
        public int DamageGive { get => _damage; set => _damage = value; }
        private void Awake()
        {
            ShutHiro += AtackAction;
        }
        private void OnDestroy()
        {
            ShutHiro -= AtackAction;

        }

        public override void InitStats<T>(T t)
        {
            _damage = Convert.ToInt32(t);
        }

        public void Atack(IHP enemysHp)
        {
           
            //if (enemysHp.HP <= 0)
            //{
            //    if (enemysHp.MaxHP <50)
            //    {
            //        HiroControl._EnergyHiro.Energy += 50;
            //    }
            //    else
            //    {
            //        HiroControl._EnergyHiro.Energy += 15;

            //    }
            //}

        }
       internal float ChensRandom()
        {
            try
            {
                return Mathf.Lerp(100, 0, _HPHiro.HP/ _HPHiro.MaxHP);
            }
            catch (Exception)
            {

                return 0;
            }
           
        }
        public void AtackOut(int damage,Action<bool> ifDead)
        {
            //_HPHiro.HP -= damage;
            //if(_HPHiro.HP < 1) 
            //{
            //    _HPHiro.Dead();
            //}
        }

        public void AtackAction()
        {
           // ShutHiro.Invoke();
        }
    }
   
}