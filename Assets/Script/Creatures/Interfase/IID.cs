using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Interfase
{
    public interface IID 
    {
        public EnemysTipe TipeEnemys { get; set; }
      public int ID {  get; set; }
    }
}