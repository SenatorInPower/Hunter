using Assets.Script.Creatures.Interfase;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroAtack : HiroControl, IAtack, IDamage
    {
        public Transform TargetShut;
        private int _damage;
        public int DamageGive { get => _damage; set => _damage = value; }


        public override void InitStats<T>(T t)
        {
            _damage = Convert.ToInt32(t);
        }

        public void Atack(IHP enemysHp)
        {
            enemysHp.HP -= _damage;


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
        public void AtackOut()
        {
            _HPHiro.HP -= _damage;
        }

        GameObject AtackNearest(List<GameObject> enemys)
        {
            return enemys.OrderBy(t => Vector3.Distance(transform.position, t.transform.position)).FirstOrDefault();

        }
    }
   
}