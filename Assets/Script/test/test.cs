using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class test : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        print("exit");
    }
    private void OnTriggerEnter(Collider other)
    {
        print("enter");

    }
}
