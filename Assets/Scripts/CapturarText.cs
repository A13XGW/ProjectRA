using UnityEngine;
using System.Collections;
using System.IO;

public class CapturarText : MonoBehaviour {
	private string TextoAGuardar;
	public GameObject panelTexto;
	public GUIText Texto;
	//private Rect miTextArea = new Rect(20,20,500,250);
	
	public void ActivarTexto(){
		panelTexto.SetActive (true);
		//TextoAGuardar = GUI.TextField(miTextArea,TextoAGuardar);
		//Texto = TextoAGuardar;
	}
	public void guardad(){
	}
}