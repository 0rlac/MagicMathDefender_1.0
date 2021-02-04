using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScriptFin : MonoBehaviour
{
    public Text txtFin;
    public Text txtRecord;
    public Text txtTiempo;
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
        if (PlayerPrefs.HasKey("Record"))
        {
            txtRecord.text = "RECORD: " + PlayerPrefs.GetFloat("Record").ToString("n2");
            txtTiempo.text = "Tiempo Actual: "+GameManager.instance.tiempo.ToString("n2");
        }
        else
        {
            txtRecord.text = "RECORD: NO TIME"; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void bottonVolverAJugar(int numero)
    {
        SceneManager.LoadScene("Nivel_" + numero);
    }
    public void volverMenu()
    {
        SceneManager.LoadScene("MenuPlay");
    }
}
