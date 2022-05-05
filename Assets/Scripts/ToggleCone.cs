using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleCone : MonoBehaviour
{
    public InputActionReference toggleCone = null;

    private void Awake()
    {
        toggleCone.action.started += Hide;

    }

    private void OnDestroy()
    {
        toggleCone.action.started -= Hide;
    }

    private void Hide(InputAction.CallbackContext context)
    {
        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive); 
    }
   
}
