using Assets.Script.Creatures.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroAtack : HiroControl, IAtack, IDamage
    {
        internal Action ShutHiro;
        internal IEnergy Energy;
        internal Transform TargetShut;
        private int _damage;
        public int DamageGive { get => _damage; set => _damage = value; }
        

        public override void InitStats<T>(T t)
        {
            _damage = Convert.ToInt32(t);
        }

        public void Atack(IHP enemysHp)
        {
            enemysHp.HP -= _damage;
            if (enemysHp.HP <= 0)
            {
                if (enemysHp.MaxHP <50)
                {
                    HiroControl._EnergyHiro.Energy += 50;
                }
                else
                {
                    HiroControl._EnergyHiro.Energy += 15;

                }
            }

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
        public void AtackOut(int damage)
        {
            _HPHiro.HP -= damage;
        }

        public void AtackAction()
        {
            ShutHiro.Invoke();
        }
    }
   
}