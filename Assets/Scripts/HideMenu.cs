using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HideMenu : MonoBehaviour
{
    public InputActionReference hideMenu = null;

    private void Awake()
    {
        hideMenu.action.started += Hide;

    }

    private void OnDestroy()
    {
        hideMenu.action.started -= Hide;
    }

    private void Hide(InputAction.CallbackContext context)
    {
        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive); 
    }
   
}
