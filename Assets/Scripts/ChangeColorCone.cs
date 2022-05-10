using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCone : MonoBehaviour

{ 

    //[SerializeField] private Material myMaterial;
    public Material[] material;
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            rend.sharedMaterial = material[1];
        }
          
    }
    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            rend.sharedMaterial = material[0];
        }

    }

    /* void OnCollisionEnter(Collision col)
     {
         if (col.gameObject.tag == "Player")
         {
             //Debug.Log("Collision Detected");
             myMaterial.color = Color.white;

         }
     }
     void OnCollisionExit(Collision col)
         {
             if (col.gameObject.tag == "Player")
         {
                 //Debug.Log("Collision Detected");
                 myMaterial.color = Color.yellow;

             }
         }*/
}
