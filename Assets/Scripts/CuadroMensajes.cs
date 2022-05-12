using UnityEngine;
using System;
using TMPro;

public class CuadroMensajes : MonoBehaviour
{
    /*public TextMeshProUGUI txtNombreAlarma;
    public TextMeshProUGUI txtTiempoAlarma;
    public TextMeshProUGUI txtHoraPnt;

    public TextMeshProUGUI txtRespuesta;
    public Renderer rendererAMS;*/


    public GameObject pantallaBienvenida;
    public GameObject pantallaGuion;
    public GameObject pantallaEscena;
    public GameObject pantallaMenuReloj;
    public GameObject pantallaCaña;
    public GameObject pantallaRodar;

    /*private void Start()
    {
       
    }

    void Update()
    {
        
    }

    
    public void Guion()
    {
        pantallaGuion.SetActive(true);
        pantallaBienvenida.SetActive(false);
    }

    public void Escena()
    {
        pantallaEscena.SetActive(true);
        pantallaGuion.SetActive(false);
    }*/
    public void MenuReloj()
    {
        pantallaMenuReloj.SetActive(true);
        pantallaEscena.SetActive(false);
    }
    public void Caña()
    {
        pantallaMenuReloj.SetActive(true);
        pantallaCaña.SetActive(false);
    }
    public void Rodar()
    {
        pantallaCaña.SetActive(true);
        pantallaRodar.SetActive(false);
    }



}
