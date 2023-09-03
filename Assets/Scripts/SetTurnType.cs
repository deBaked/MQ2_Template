using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{
    [SerializeField] ActionBasedSnapTurnProvider snapTurn;
    [SerializeField] ActionBasedContinuousTurnProvider continuousTurn;

    private int lastIndex;

    public void SetTypeFromIndex(int index)
    {
        try
        {
            lastIndex = index;

            if (index == 0)
            {
                snapTurn.enabled = false;
                continuousTurn.enabled = true;
            }
            else if (index == 1)
            {
                snapTurn.enabled = true;
                continuousTurn.enabled = false;
            }
        }
        catch (NullReferenceException)
        {
            index = lastIndex;
        }
        
    }
}
