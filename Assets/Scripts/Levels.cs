using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public Button nivel2,nivel3,nivel4, nivel5, nivel6,examen;
    public Text txtpuntaje;

    // Start is called before the first frame update
    private void Start()
    {
        DesbloquarNivel();
        txtpuntaje.text = "Puntaje: "+PlayerPrefs.GetInt("RecordPuntaje").ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambiarNivel(int num)
    {
        if (num == 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            SceneManager.LoadScene("Nivel_" + num);
        }
    }
    public void DesbloquarNivel()
    {
        if (PlayerPrefs.GetInt("RecordPuntaje") >=10 && PlayerPrefs.GetInt("RecordPuntaje") < 20)
        {
            nivel2.interactable = true;
            nivel3.interactable = false;
            nivel4.interactable = false;
            nivel5.interactable = false;
            nivel6.interactable = false;
            examen.interactable = false;
        }
        else if (PlayerPrefs.GetInt("RecordPuntaje") >= 20 && PlayerPrefs.GetInt("RecordPuntaje") < 30)
        {
            nivel2.interactable = true;
            nivel3.interactable = true;
            nivel4.interactable = false;
            nivel5.interactable = false;
            nivel6.interactable = false;
            examen.interactable = false;
        }
        else if (PlayerPrefs.GetInt("RecordPuntaje") >= 30 && PlayerPrefs.GetInt("RecordPuntaje") < 40)
        {
            nivel2.interactable = true;
            nivel3.interactable = true;
            nivel4.interactable = true;
            nivel5.interactable = false;
            nivel6.interactable = false;
            examen.interactable = false;
        }
        else if (PlayerPrefs.GetInt("RecordPuntaje") >= 40 && PlayerPrefs.GetInt("RecordPuntaje") < 50)
        {
            nivel2.interactable = true;
            nivel3.interactable = true;
            nivel4.interactable = true;
            nivel5.interactable = true;
            nivel6.interactable = false;
            examen.interactable = false;
        }
        else if (PlayerPrefs.GetInt("RecordPuntaje") >= 50 && PlayerPrefs.GetInt("RecordPuntaje") < 60)
        {
            nivel2.interactable = true;
            nivel3.interactable = true;
            nivel4.interactable = true;
            nivel5.interactable = true;
            nivel6.interactable = true;
            examen.interactable = false;
        }
        else if (PlayerPrefs.GetInt("RecordPuntaje") >= 60)
        {
            nivel2.interactable = true;
            nivel3.interactable = true;
            nivel4.interactable = true;
            nivel5.interactable = true;
            nivel6.interactable = true;
            examen.interactable = true;
        }
    }
}
