using Assets.Script.Creatures.Interfase;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroEnergy : HiroControl, IEnergy
    {
        internal Action<GameObject> Ultimate;
        private int _energy;
        public int Energy { get => _energy; set => _energy=value; }

        public override void InitStats<T>(T t)
        {
            _energy = Convert.ToInt32(t);
        }
       
       public void UltimateHiro(GameObject UltPrefab)
        {
            Instantiate(UltPrefab, transform);
        }
    }
}