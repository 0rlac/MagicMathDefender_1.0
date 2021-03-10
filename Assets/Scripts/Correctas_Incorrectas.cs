using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correctas_Incorrectas : MonoBehaviour
{
    
     int contadorCorrectas = 0;
     int contadorIncorrectas = 0;
    // Start is called before the first frame update
    public void Correctas()
    {
        contadorCorrectas += 1;
        
    }
    public void Incorrectas()
    {
        contadorIncorrectas += 1;

    }
}
