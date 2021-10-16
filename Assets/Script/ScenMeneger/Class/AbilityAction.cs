using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class AbilityAction: MonoBehaviour, IPointerDownHandler
{
  
    public GameObject particle;
    public int TimeReset;

    internal Action<GameObject> action;
    bool Eneble = true;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (Eneble)
        {           
            DOTween.To(() => TimeReset, x => TimeReset = x, 3, 3).OnComplete(() => Eneble = true);

            action.Invoke(particle);

            Eneble = false;
        }
    }
}
