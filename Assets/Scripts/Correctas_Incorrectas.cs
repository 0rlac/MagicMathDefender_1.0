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
        Cursor.visible = false;
       // Cursor.lockState = CursorLockMode.Locked;
    }
    public void Incorrectas()
    {
        contadorIncorrectas += 1;
        Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }
}
