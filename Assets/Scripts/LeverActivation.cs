using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class LeverActivation : MonoBehaviour
{
    [SerializeField] Collider collider1, collider2;
    //[SerializeField] XRGrabInteractable interactable;
    [SerializeField] UnityEvent OnLevelPullComplete, OnLevelPullExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lever"))
        {
            OnLevelPullComplete.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Lever"))
        {
            OnLevelPullExit.Invoke();
        }
    }
}
