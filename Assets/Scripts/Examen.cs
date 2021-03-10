using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen : MonoBehaviour
{
    public string examen;
    public void DarExamen()
    {
        Application.OpenURL(examen);
    }

}
