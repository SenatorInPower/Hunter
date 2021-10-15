using Assets.Script.Creatures.Interfase;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroEnergy : HiroControl, IEnergy
    {
        internal Ultimate Ultimate;
        private int _energy;
        public int Energy { get => _energy; set => _energy=value; }

        public override void InitStats<T>(T t)
        {
           
        }
    
    }
}