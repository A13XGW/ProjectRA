using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class finaliza : MonoBehaviour {
	public GameObject Grupo;

	public void OnButtonDown(){
		DontDestroyOnLoad (Grupo.gameObject);
		Grupo.GetComponent<Salvar> ();
		Application.LoadLevel ("Fase1");
	}
}
