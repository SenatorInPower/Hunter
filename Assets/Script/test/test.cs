using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    GameObject AtackNearest(List<GameObject> enemys)
    {
       return enemys.OrderBy(t => Vector3.Distance(transform.position, t.transform.position)).FirstOrDefault();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
