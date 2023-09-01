using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateGrabRay : MonoBehaviour
{
    [SerializeField] GameObject rGrabRay;

    public XRDirectInteractor rDirectGrab;


    void Update()
    {
        rGrabRay.SetActive(rDirectGrab.interactablesSelected.Count == 0);
    }
}
