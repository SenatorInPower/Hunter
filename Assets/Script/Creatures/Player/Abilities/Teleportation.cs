using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation 
{
    void MoveFromTheBorder()
    {
        Vector3 centerOfRadius = new Vector3(5, 3, 0);
        float radius = 10f;
        Vector3 target = centerOfRadius + (Vector3)(radius * UnityEngine.Random.insideUnitCircle);
    }
 
}
