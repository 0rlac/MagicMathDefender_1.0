using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public GameObject Enemigo;
    public float Tiempo;
    public int TiempoDeAparicionn;
    private void Update()
    {
        Tiempo -= Time.deltaTime;
        if (Tiempo <=0)
        {
            Instantiate(Enemigo, transform.position, transform.rotation);
            Tiempo = TiempoDeAparicionn;
        }
    }
}
