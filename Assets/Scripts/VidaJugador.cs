    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class VidaJugador : MonoBehaviour,IDaño
{
    public Transform target;
    int vidaJugador=100;
    public Text mostratVida;

    public GameObject EfectoDaño;
    public float IntervaloInmunidad = 0.5f;
    float TiempoInmunidad;
     
    WaitForSeconds esperar;
    // Start is called before the first frame update
    void Start()
    {
        EfectoDaño.SetActive(false);
        TiempoInmunidad = 0.0f;
        esperar = new WaitForSeconds(0.2f);
        ControladorDeCanvas.instance.AñadirTextoDeVida(vidaJugador);
    }
    private void Update()
    {
        TiempoInmunidad -= Time.deltaTime;
    }
     bool IDaño.dañohecho(int valor)
    {
        if (target.tag== "Enemigo")
        {
            if (TiempoInmunidad <=0)
            {
                vidaJugador = vidaJugador - valor;
                StartCoroutine(Efecto());
                ControladorDeCanvas.instance.AñadirTextoDeVida(vidaJugador);
            }
            
            return true;
        }
        return false;
    }
    IEnumerator Efecto()
    {
        TiempoInmunidad = IntervaloInmunidad;
        EfectoDaño.SetActive(true);
        yield return esperar;
        EfectoDaño.SetActive(false);
        
        if (vidaJugador <=0)
        {
            GameManager.instance.FinDelJuego(false);
        }
    }
    void musica()
    {
        if (vidaJugador>0)
        {

        }
    }
}
