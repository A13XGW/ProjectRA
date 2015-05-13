using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class CapturarText : MonoBehaviour {
	public string TextoAGuardar;
	public InputField CampoTexto;
	public void ActivarTexto (){
		CampoTexto.gameObject.SetActive (true);
	}
	public void guardar(){
		TextoAGuardar = CampoTexto.text;
		System.IO.File.WriteAllText ("./Resources/Fase1/Comentarios", TextoAGuardar);
		//Debug.

	}
}