using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class UIAction: MonoBehaviour, IPointerDownHandler
{
    public GameObject particle;
    internal Action<GameObject> action;
    public void OnPointerDown(PointerEventData eventData)
    {
        action.Invoke(particle);
    }
}
