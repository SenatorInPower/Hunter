using Assets.Script.Creatures.Interfase;
using System;
using System.Collections.Generic;

namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroAtack : HiroControl, IAtack, IDamage
    {
         
        private int _damage;
        public int DamageGive { get => _damage; set => _damage = value; }


        public override void InitStats<T>(T t)
        {
            _damage = Convert.ToInt32(t);
        }

        public void Atack(IHP hp)
        {
            hp.HP -= _damage;
        }

        public void AtackOut()
        {
            _HPHiro.HP -= _damage;
        }
    }
   
}