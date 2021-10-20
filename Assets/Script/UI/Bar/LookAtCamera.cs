using Assets.Script.ScenMeneger.Class;
using System.Collections;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{

    WaitForSeconds WaitForSeconds = new WaitForSeconds(0.5f);

    private void OnEnable()
    {
        StartCoroutine(Look());
    }

    private void OnDisable()
    {
        StopCoroutine(Look());
    }

    IEnumerator Look()
    {
        while (true)
        {
            transform.LookAt(Spawn.Camera.transform.position);
           yield return WaitForSeconds;
        }
    }
}
