using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    [SerializeField] GameObject menu, playerHead;
    [SerializeField] InputActionProperty showButton;
    [SerializeField] float spawnDistance = 2f;

    void Update()
    {
        if (showButton.action.WasPerformedThisFrame())
        {
            menu.transform.position = playerHead.transform.position + new Vector3(playerHead.transform.forward.x, 0, playerHead.transform.forward.z).normalized * spawnDistance;
            menu.SetActive(!menu.activeSelf);
        }

        // menu tracks player head position and looks toward it
        menu.transform.LookAt(new Vector3(playerHead.transform.position.x, playerHead.transform.position.y, playerHead.transform.position.z));
        menu.transform.forward *= -1; // this flips the forward direction so menu will always face player

    }
}
