using Assets.Script.Creatures.Interfase;
using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Enemys.Class
{
    public class EnemysAtackRed : EnemysAtack, IAtackAction
    {
        public void AtackAction()
        {


        }

        void Dead()
        {
            print("Dead");
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == ControlerLevel.NameTagHiro)
            {
                gameObject.SetActive(false);
                Dead();
            }
        }
    }
}