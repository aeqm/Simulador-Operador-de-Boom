using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PoleBehaviour : MonoBehaviour
{
    public InputActionReference ExtendPole = null;
    public InputActionReference ContractPole = null;

    public int maxPoleLenght = 4;
    public int minPoleLenght = 1;

    private void Awake()
    {
        ExtendPole.action.started += Extend;
        ContractPole.action.started += Contract;

    }

    private void Extend(InputAction.CallbackContext context)
        {
            
                if (transform.localScale.x <= maxPoleLenght)
                    transform.localScale += new Vector3(1, 0, 0);
          
        }


        private void Contract(InputAction.CallbackContext context)
        {

                if (transform.localScale.x > minPoleLenght)
                    transform.localScale -= new Vector3(1, 0, 0);
        }
        
    
}

