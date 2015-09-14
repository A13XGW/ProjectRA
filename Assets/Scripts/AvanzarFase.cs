using UnityEngine;
using System.Collections;

public class AvanzarFase : MonoBehaviour {
	public int contadorFase;
	public GameObject cargando;

	public void cargar(){
		cargando.SetActive (true);
		
	}
	public void OnButtonDown(){
		contadorFase++;
		Application.LoadLevel ("Fase"+contadorFase);
	}

}
