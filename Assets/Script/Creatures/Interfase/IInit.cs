using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Interfase
{
    public interface IInit 
    {
        public void InitStats<T>(T t);
    }
}