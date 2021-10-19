﻿using Assets.Script.Creatures.Interfase;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroEnergy : HiroControl, IEnergy
    {
        internal Action<GameObject> Ultimate;

        [SerializeField]
        private int _energy;
        public int Energy { get =>Mathf.Clamp(_energy, 0, 100); set => _energy=value; }

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