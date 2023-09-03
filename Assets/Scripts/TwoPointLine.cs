using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TwoPointLine : MonoBehaviour
{
    [SerializeField] Transform pointA, pointB;
    private LineRenderer line;
    
    void Start()
    {
        line = GetComponent<LineRenderer>();    // grabs line renderer component
    }

    void Update()
    {   
        // sets the first and second positions accordingly, from transforms assigned
        line.positionCount = 2;
        line.SetPosition(0, pointA.position);
        line.SetPosition(1, pointB.position);
    }
}
