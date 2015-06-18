using UnityEngine;
using System.Collections;

public class inciar : MonoBehaviour {

	public GameObject botonEval;
	public void OnButtonDown(){
		Application.LoadLevel ("Fase1");
	}
	public void OnButtonDown2(){
		Application.LoadLevel ("Fase6");
	}

	void Start() {
		if (PlayerPrefs.GetInt ("FaseFinal") == 6) {
			botonEval.SetActive(true);
		}
	}
}
