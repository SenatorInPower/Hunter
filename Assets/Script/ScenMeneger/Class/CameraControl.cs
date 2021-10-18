using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//not use
public class CameraControl : MonoBehaviour
{
    internal Camera camera;
    private ETCJoystick right;

    private void Awake()
    {
        camera = Camera.main;
        right=GameObject.FindGameObjectWithTag("Finish").GetComponent<ETCJoystick>(); 
    }
    void Update()
    {
        //this will make the camera look "inwards" towards Pivot
        camera.transform.LookAt(transform);

        float speed = 10.0f;
        transform.Rotate(Vector3.up, right.axisX.axisValue* speed);
        transform.Rotate(Vector3.left, right.axisY.axisValue * speed);
    }
}
