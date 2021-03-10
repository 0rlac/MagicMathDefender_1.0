using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masbalas : MonoBehaviour
{
    public AccionesDelJugador aumentarCargador;
    int contadorCorrectas = 0;
    // Start is called before the first frame update
    
    public void masMunicion()
    {
        
        aumentarCargador.municion += 10;
        ControladorDeCanvas.instance.AñadirTextoMunicion(aumentarCargador.municion);
        contadorCorrectas += 1;
        //ControladorDeCanvas.instance.AñadirTextoCorrectas(contadorCorrectas);
    }
}
