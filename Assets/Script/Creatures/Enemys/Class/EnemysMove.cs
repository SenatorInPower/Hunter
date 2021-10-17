using Assets.Script.Creatures.Interfase;
using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;
namespace Assets.Script.Creatures.Enemys.Class
{
    public abstract class EnemysMove : EnemysControl, IMove, IInit
    {
        private  int _speed;
        public int Speed { get => _speed; set => _speed = value; }

        public void InitStats<T>(T t)
        {
            _speed = Convert.ToInt32(t);
        }

    }
}