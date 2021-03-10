using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ActivadorPregunta : MonoBehaviour {
	public GameObject Pregunta;
	private float StartTime;
	public Text texto;


	// Use this for initialization
	void Start () {
		Pregunta.SetActive (false);

	}
    void OnTriggerEnter(Collider col){
		switch (col.gameObject.tag){
		case "Player":
				Cursor.visible = true;
			Pregunta.SetActive (true);
				Time.timeScale = 0.1f;
			break;
		}
	}
	
}
