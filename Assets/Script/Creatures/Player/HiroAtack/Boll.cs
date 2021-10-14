using System;
using UnityEngine;

namespace Assets.Script.Creatures.Player.HiroAtack
{
    public class Boll : MonoBehaviour
    {
        internal int Damage;
        internal Action<IHP> BollCollision;
        const string EnemysTag = "Enemys";
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == EnemysTag)
            {
                BollCollision.Invoke(collision.gameObject.GetComponent<IHP>());
            }
        }
    }
}