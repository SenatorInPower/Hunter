using Assets.Script.Creatures.Interfase;
using DG.Tweening;
using System;
using System.Collections;
using UnityEngine;
namespace Assets.Script.Creatures.Enemys.Class
{
    public abstract class EnemysMove : EnemysControl, IMove, IInit,IHiroTransform
    {
        private Transform _hiroMove;
        public Transform HiroTransform { get => _hiroMove; set => _hiroMove=value; }

       
        private int _speed;
        public int Speed { get => _speed; set => _speed = value; }
        //internal IID _ID;

      


        public void InitStats<T>(T t)
        {
            _speed = Convert.ToInt32(t);
        }


    }
}