using Assets.Script.Creatures.Interfase;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroMove : HiroControl, IMove
    {
        private int _speed;
        public int Speed { get => _speed; set => _speed = value; }



        public override void InitStats<T>(T speed)
        {
            _speed = Convert.ToInt32(speed);


        }
        void Teleportation()
        {

        }
        void MoveFromTheBorder()
        {

        }
    }
}