using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int Ganaste = -1;
    public float t; 

    public Text txtPreguntas;
    public int preguntas;
    public GameObject contenedorPreguntas;

    public float tiempo;
    public Text txtTiempo;
    private void Start()
    {
        instance = this;
        preguntas = contenedorPreguntas.GetComponentsInChildren<ActivadorPregunta>().Length;
        txtPreguntas.text = "Preguntas Restantes: " + preguntas.ToString();
        tiempo = 0.0f;
        txtTiempo.text = "Tiempo: " + tiempo.ToString("n2");
    }
    private void Update()
    {
        tiempo += Time.deltaTime;
        txtTiempo.text = "Tiempo: " + tiempo.ToString("n2");    
    }
    public void PreguntasRespondidas()
    {
        preguntas--;
        txtPreguntas.text = "Preguntas Restantes: " + preguntas.ToString();
        if (preguntas<=0)
        {
            FinDelJuego(true);
        }
    }
    public void FinDelJuego(bool Ganaste)
    {
        if (Ganaste==true)
        {
            Debug.Log("Has Ganado");
            GameManager.Ganaste = 1;
            if (PlayerPrefs.HasKey("Record")==true)
            {
                t = PlayerPrefs.GetFloat("Record");
                if (tiempo < t)
                {
                    PlayerPrefs.SetFloat("Record", tiempo);
                }
            }
            else
            {
                PlayerPrefs.SetFloat("Record", tiempo);
            }
            PlayerPrefs.Save();
        }
        else
        {
            Debug.Log("Has Perdido");
            GameManager.Ganaste = 0;
        }
        SceneManager.LoadScene(3);
    }
}
