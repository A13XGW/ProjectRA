using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MostrarIns : MonoBehaviour {

	public GameObject pantalla;
	public TextAsset archivo;
	public Text texto;
	// Use this for initialization
	void Start () {
		pantalla.SetActive (true);
		texto.text = archivo.text;
	}

	public void Oculta() {
		pantalla.SetActive (false);
	}

	public void MenuNavegar(int nivel) {
		if (nivel==0) {
			Application.LoadLevel("iniciar");
		} else {
			Application.LoadLevel("Fase" + nivel);
		}
	}

}
