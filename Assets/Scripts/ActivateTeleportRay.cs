using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportRay : MonoBehaviour
{
    [SerializeField] GameObject RTele;
    [SerializeField] InputActionProperty rActivate, rCancel;

    void Update()
    {
        // only enable teleporting if trigger is being pressed AND player is not holding an item 
        RTele.SetActive(rCancel.action.ReadValue<float>() == 0 && rActivate.action.ReadValue<float>() > 0.1f);
    }
}
