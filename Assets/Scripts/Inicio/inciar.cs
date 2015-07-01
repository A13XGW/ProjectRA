using UnityEngine;
using System.Collections;

public class inciar : MonoBehaviour {
	public GameObject Registro;
	public GameObject botonEval;

	public void OnButtonDown(){
		Registro.SetActive (true);
	}
	public void OnButtonDown2(){
		Application.LoadLevel ("Fase6");
	}

	void Start() {
		//PlayerPrefs.SetInt ("FaseFinal", 0);
		if (PlayerPrefs.GetInt ("FaseFinal") == 6) {
			botonEval.SetActive(true);
		}
	}
}
