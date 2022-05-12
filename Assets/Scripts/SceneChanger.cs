using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
   
    public void Scene1()
    {
        SceneManager.LoadScene("Scene1Title");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("Scene2Guion");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("Scene3EnSet");
        
    }
    public void Scene4()
    {
        SceneManager.LoadScene("Tut");
    }
}
