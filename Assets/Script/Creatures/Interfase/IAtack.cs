using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Interfase
{
    public interface IAtack 
    {
        public void AtackOut(IHP hp);
        public void Atack(IHP hp);
    }
}