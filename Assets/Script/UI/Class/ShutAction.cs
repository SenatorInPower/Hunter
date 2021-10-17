using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Script.ScenMeneger.UI
{
    public class ShutAction : MonoBehaviour,IDragHandler,IBeginDragHandler
    {
        public Transform ShutPoint;
        //internal UnityAction ShutButton;

        private Camera _camera;
        private Vector3 screenPoint;
        //public Vector3 offset;

        public Button Shut;
        private void OnEnable()
        {
          //  ShutButton += ShutInit;
        }
        private void OnDisable()
        {
         //   ShutButton -= ShutInit; 
        }
        private void Awake()
        {
            _camera = Camera.main;
            
        }
      
       public void InitShut(UnityAction action)
        {
            Shut.onClick.AddListener(action);
        }
  

        public void OnBeginDrag(PointerEventData eventData)
        {
            screenPoint = _camera.WorldToScreenPoint(gameObject.transform.position);

          //  offset = ShutPoint.transform.position - _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        }

        public void OnDrag(PointerEventData eventData)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

             curScreenPoint = _camera.ScreenToWorldPoint(curScreenPoint) /*+ offset*/;
            ShutPoint.position = curScreenPoint;
        }
        //private void OnDrawGizmos()
        //{
        //    Vector3 forward = ShutPoint.position-_camera.transform.forward ;
        //    Debug.DrawRay(ShutPoint.position, forward);
        //}
    }
}