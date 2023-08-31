using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportRay : MonoBehaviour
{
    [SerializeField] GameObject RTele;
    [SerializeField] InputActionProperty rActivate;

    void Update()
    {
        RTele.SetActive(rActivate.action.ReadValue<float>() > 0.1f);
    }
}
