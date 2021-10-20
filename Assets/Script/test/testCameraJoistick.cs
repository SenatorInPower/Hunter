using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCameraJoistick : MonoBehaviour
{
    public Transform target;
  
    public ETCJoystick left;
    public float speed;
    void Update()
    {
        //this will make the camera look "inwards" towards Pivot
        // camera.transform.LookAt(target);
        //target.rotation *= Quaternion.Euler(right.axisX.axisValue, right.axisY.axisValue, 0);
        //target.Rotate(Vector3.up, right.axisY.axisValue * speed);
        //target.Rotate(Vector3.left, right.axisX.axisValue* speed);
        target.Translate(new Vector3(left.axisX.axisValue, 0f, left.axisY.axisValue) * speed * Time.deltaTime);

        //float yRot = speed * right.axisY.axisValue;
        //float xRot = speed * right.axisX.axisValue;

        //target.Rotate(xRot, yRot, 0.0f);
    }
}
