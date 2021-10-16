using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Enemys.Class
{
    public class EnemysAtackRed : EnemysAtack
    {
      
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