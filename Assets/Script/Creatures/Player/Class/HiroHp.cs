using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroHP : HiroControl, IHP
    {
        private int _HP;
        public int HP { get => _HP; set => _HP = value; }

        public override void InitStats<T>(T hp)
        {
            _HP = Convert.ToInt32(hp);
        }

        private void Start()
        {

        }
    }
}