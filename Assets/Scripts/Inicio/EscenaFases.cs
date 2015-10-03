using UnityEngine;
using System.Collections;

public class EscenaFases : MonoBehaviour {
	public GameObject Fases;
	private int bandera;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (bandera == 0) {
			if (Input.GetKeyDown (KeyCode.F12)) {//Condicional - Listener de la tecla F12 para una accion especifica
				Fases.SetActive (true);
				bandera = 1;
			}
		} else {
			if (Input.GetKeyDown (KeyCode.F12)) {//Condicional - Listener de la tecla F12 para una accion especifica
				Fases.SetActive (false);
				bandera = 0;
			}
		}
	}
}
