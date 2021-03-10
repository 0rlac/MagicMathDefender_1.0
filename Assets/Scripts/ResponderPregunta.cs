using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResponderPregunta : MonoBehaviour {


	public Text canva_puntos;
	public int puntosPorRespuesta=0;
	public GameObject activadorPregunta;
	public GameObject Pregunta;
	public static int puntos;
	public int multiplicadorPuntos;

	void Start() {

		canva_puntos.text = "puntos: " + puntos;
		
	}
    public void Preguntas(){

		puntos=puntos + (puntosPorRespuesta * multiplicadorPuntos);
		StartCoroutine (res_correcta ());
	}

	IEnumerator res_correcta(){
		
		gameObject.GetComponent<AudioSource> ().Play();
		canva_puntos.text = "Puntos: " + puntos;
		yield return new WaitForSeconds (0.5f);
		canva_puntos.text = "Puntos: " + puntos;
		//activadorPregunta.GetComponent<Collider> ().enabled = false;
	}
	public void Despausear()
	{
		
		Destroy(Pregunta);
		Destroy(activadorPregunta);
		GameManager.instance.PreguntasRespondidas();
		Time.timeScale = 1.0f;

	}

}
