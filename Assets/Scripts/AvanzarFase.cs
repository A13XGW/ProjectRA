using UnityEngine;
using System.Collections;

public class AvanzarFase : MonoBehaviour {
	public int contadorFase;
	public void OnButtonDown(){
		contadorFase++;
		Application.LoadLevel ("Fase"+contadorFase);
	}
}
