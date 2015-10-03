using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DeleteAlert : MonoBehaviour {
	public GameObject alerta;
	public GameObject MostrarCpTxt;
	public void OnMouseDown(){
		alerta.SetActive (false);//Desactiva la el cuadro de dialogo emergente
		MostrarCpTxt.SetActive (true);
		//Destroy (alerta);
	}
}
