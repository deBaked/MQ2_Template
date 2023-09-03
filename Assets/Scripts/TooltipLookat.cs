using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipLookat : MonoBehaviour
{
    [SerializeField] Transform target;
    
    void Update()
    {
        transform.LookAt(target, Vector3.up);
    }
}
