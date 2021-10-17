using Assets.Script.Creatures.Interfase;
using System;
using UnityEngine;
namespace Assets.Script.Creatures.Enemys.Class
{
    public abstract class EnemysAtack : MonoBehaviour, IAtack, IDamage, IInit
    {
        public EnemysControl Control;
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
            Control.HPHiro.HP -= _damage;
            if (Control.HPHiro.HP < 1)
            {
                Control.HPHiro.Dead();
            }
        }

        public void AtackOut(int damage)
        {
            Control.HPEnemys().HP -= damage;
            if (Control.HPEnemys().HP < 1)
            {
                Control.EnergyHiro.Energy += Control.EnergyToHiro;
                Control.HPEnemys().Dead();
            }
        }

        public void InitStats<T>(T t)
        {
            _damage = Convert.ToInt32(t);

        }
    }
}