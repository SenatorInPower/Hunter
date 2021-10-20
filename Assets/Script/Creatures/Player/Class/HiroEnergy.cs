using Assets.Script.Creatures.Interfase;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroEnergy : HiroControl, IEnergy
    {
        internal MoveStatsBar EnergyBar;

        internal Action<GameObject> Ultimate;

        [SerializeField]
        private int _energy;
        public int Energy { get => _energy; set { _energy = Mathf.Clamp(value, 0, 100); EnergyBar.MoveStats(Energy); } }

        private void Awake()
        {
            Ultimate += UltimateHiro;
        }
        private void OnDestroy()
        {
            Ultimate = UltimateHiro;

        }
        public override void InitStats<T>(T t)
        {
            _energy = Convert.ToInt32(t);
        }
       
       public void UltimateHiro(GameObject particle)
        {
            if (particle != null)
            {
                    Instantiate(particle, transform);   
            }
        }
    }
}