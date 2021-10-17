using Assets.Script.Creatures.Interfase;
using System;
using UnityEngine;

namespace Assets.Script.Creatures.Enemys.Class
{
    public class EnemysAtackRed : EnemysAtack, IAtackAction
    {


        public void AtackAction(Action fin)
        {

        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == ControlerLevel.NameTagHiro)
            {
                Control.AtackEnemys().Atack(null);  // нуль для того чтобы не тратить время на вытягивание хп героя, хп есть в интерфейсе
                AtackAction(null);
                Control.HPEnemys().Dead();
            }
        }
    }
}