using Assets.Script.Creatures.Interfase;
using System;
using UnityEngine;
namespace Assets.Script.Creatures.Enemys.Class
{
    public abstract class EnemysMove : MonoBehaviour, IMove, IInit
    {
        internal EnemysControl Control;

        [SerializeField]
        private int _speed;
        public int Speed { get => _speed; set => _speed = value; }

        public void InitStats<T>(T t)
        {
            _speed = Convert.ToInt32(t);
        }

    }
}