using Assets.Script.Creatures.Interfase;
using System;
using UnityEngine;
namespace Assets.Script.Creatures.Enemys.Class
{
    public abstract class EnemysAtack : EnemysControl, IAtack, IDamage, IInit, IHiroStats
    {

        private int _damage;
        public int DamageGive { get => _damage; set => _damage = value; }
      
     
        // internal IID _ID;
        private void Awake()
        {
            CapsuleCollider Collider;
            Collider = gameObject.GetComponent<CapsuleCollider>();

            if (Collider == null)
            {
                gameObject.AddComponent<CapsuleCollider>().isTrigger = true;
                Collider = gameObject.GetComponent<CapsuleCollider>();
            }
            Collider.isTrigger = true;
        }

        public void Atack(IHP hiro)
        {
            HPHiro.HP -= _damage;
            if (HPHiro.HP < 1)
            {
                HPHiro.Dead();
            }
        }

        public void AtackOut(int damage)
        {
            _HPEnemys.HP -= damage;
            if (_HPEnemys.HP < 1)
            {
                EnergyHiro.Energy += EnergyToHiro;
                _HPEnemys.Dead();
            }
        }

        public void InitStats<T>(T t)
        {
            _damage = Convert.ToInt32(t);

        }
    }
}