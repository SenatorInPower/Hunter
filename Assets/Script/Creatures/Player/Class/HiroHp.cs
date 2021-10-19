using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Script.Creatures.Player.Class
{
    public sealed class HiroHP : HiroControl, IHP
    {
        [SerializeField]
        private int _HP;
        public int HP { get => _HP; set { _HP = value; /*if (_HP < 1) { _dead.Invoke(); }*/ /*  if (_HP == MaxHP) { gameObject.SetActive(true); Time.timeScale = 1; }*/ } }
        private int _maxHP;
        public int MaxHP { get => _maxHP; }
        private Action _dead;
        public Action Dead { get => _dead; set => _dead=value; }

        public override void InitStats<T>(T hp)
        {
            _HP = Convert.ToInt32(hp);
            _maxHP = _HP;
        }
        private void Awake()
        {
            _dead += DeadHiro;
        }
        private void OnDestroy()
        {
            _dead -= DeadHiro;

        }
        void DeadHiro()
        {
            gameObject.SetActive(false);
           // Time.timeScale = 0;
        }
    }
}