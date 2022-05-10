using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCubes : MonoBehaviour
{
      
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Cono"))
        {
           
            Debug.Log("Collision Detected");

        }
    }
}
