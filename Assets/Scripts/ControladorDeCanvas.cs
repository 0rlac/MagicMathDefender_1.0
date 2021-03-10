using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControladorDeCanvas : MonoBehaviour
{
    public Text txtVida, txtMunicion;
  
    public static ControladorDeCanvas instance;
    
    private void Awake()
    {
        instance = this;
    }
    public void AñadirTextoDeVida(int valorVida)
    {
        txtVida.text = "HP: " + valorVida.ToString();
    }
    public void AñadirTextoMunicion(int valorMunicion)
    {
        txtMunicion.text = "Municion: " + valorMunicion.ToString();
    }
    /*public void AñadirTextoCorrectas(int valorCorrectas)
    {
        txtCorrectas.text = "Correctas: " + valorCorrectas;
    }
    public void AñadirTextoIncorrectas(int valorIncorrectas)
    {
        txtIncorrectas.text = "Incorrectas: " + valorIncorrectas;
    }*/
}

    