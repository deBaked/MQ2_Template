using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateTeleportRay : MonoBehaviour
{
    [SerializeField] GameObject RTele;
    [SerializeField] InputActionProperty rActivate, rCancel;

    [SerializeField] XRRayInteractor rRay;

    void Update()
    {
        bool isRRayHovering = rRay.TryGetHitInfo(out Vector3 rPos, out Vector3 rNormal, out int rNumber, out bool rValid);

        // only enable teleporting if not hovering with ray AND trigger is being pressed AND player is not holding an item 
        RTele.SetActive(!isRRayHovering && rCancel.action.ReadValue<float>() == 0 && rActivate.action.ReadValue<float>() > 0.1f);
    }
}
