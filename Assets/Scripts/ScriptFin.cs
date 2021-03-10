using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScriptFin : MonoBehaviour
{
    public static ScriptFin instance;
    public Text txtFin;
    public Text txtRecord, txtRecordPuntaje;
    public Text txtTiempo , txtPuntaje;
    


    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Ganaste==0)
        {
            txtFin.text = "Has Perdido";
            txtFin.color = Color.red;
            txtFin.enabled = true;
        }
        else if (GameManager.Ganaste==1)
        {
            txtFin.text = "Has Ganado";
            txtFin.color = Color.blue;
            txtFin.enabled = true;
        }
        else
        {
            txtFin.enabled = false;
        }
        record();
        recordPuntaje();
    }
    

        public void volverMenu()
    {
       
        SceneManager.LoadScene("MenuPlay");
        ResponderPregunta.puntos = 0;
    }
    void record()
    {
        if (PlayerPrefs.HasKey("Record") && PlayerPrefs.HasKey("RecordPuntaje"))
        {
            txtRecord.text = "RECORD: " + PlayerPrefs.GetFloat("Record").ToString("n2");
            txtTiempo.text = "Tiempo Actual: " + GameManager.tiempo.ToString("n2");
        }
        else
        {
            txtRecord.text = "RECORD: NO TIME";

        }
    }
    void recordPuntaje()
    {
        if (PlayerPrefs.HasKey("Record") && PlayerPrefs.HasKey("RecordPuntaje"))
        {
            txtRecordPuntaje.text = "RECORD PUNTAJE : " + PlayerPrefs.GetInt("RecordPuntaje").ToString();
            txtPuntaje.text = "Puntaje Actual: " + ResponderPregunta.puntos.ToString();
        }
        else
        {
            txtRecordPuntaje.text = "RECORD PUNTAJE: NO ";

        }
    }

}
