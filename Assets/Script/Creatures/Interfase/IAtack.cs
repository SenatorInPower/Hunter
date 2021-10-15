using System;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Interfase
{
    public interface IAtack 
    {
        public void AtackOut(int damage);
        public void Atack(IHP HP);
    }
}