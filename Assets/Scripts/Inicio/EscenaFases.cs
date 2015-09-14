using UnityEngine;
using System.Collections;

public class EscenaFases : MonoBehaviour {
	public GameObject Fases;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			if (Input.GetKeyDown (KeyCode.F12)) {//Condicional - Listener de la tecla F12 para una accion especifica
				Fases.SetActive(true);
			}
	}
}
