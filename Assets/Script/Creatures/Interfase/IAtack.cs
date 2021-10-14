using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Interfase
{
    public interface IAtack 
    {
        public void AtackOut();
        public void Atack(IHP enemysHp);
    }
}