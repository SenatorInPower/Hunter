using Assets.Script.Creatures.Interfase;
using Assets.Script.Creatures.Player.Class;
using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
namespace Assets.Script.ScenMeneger.UI
{
    public class AbilityAction : MonoBehaviour, IPointerDownHandler
    {

        public GameObject particle;
        public int TimeReset;
        public int EnergyToUseAbility;
        internal Action<GameObject> action;
        internal IEnergy _HiroEnergy;
        bool Eneble = true;
        public void OnPointerDown(PointerEventData eventData)
        {
            if (Eneble&& EnergyToUseAbility<= _HiroEnergy.Energy)
            {
                _HiroEnergy.Energy-= EnergyToUseAbility;
                DOTween.To(() => TimeReset, x => TimeReset = x, 3, 3).OnComplete(() => Eneble = true);

                action.Invoke(particle);

                Eneble = false;
            }
        }
    }
}