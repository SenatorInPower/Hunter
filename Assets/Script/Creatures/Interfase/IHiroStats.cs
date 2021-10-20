using System.Collections;
using UnityEngine;

namespace Assets.Script.Creatures.Interfase
{
    public interface IHiroStats 
    {
       public Transform HiroTransform { get; set; }
        public IHP HPHiro { get; set; }
        public IEnergy EnergyHiro { get; set; }
    }
}