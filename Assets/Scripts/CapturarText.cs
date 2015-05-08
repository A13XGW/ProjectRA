using UnityEngine;
using System.Collections;
using System.IO;

public class CapturarText : MonoBehaviour {
	private string TextoAGuardar = "Escribe tus comentarios acerca de las imagenes";
	private Rect miTextArea = new Rect(20,20,500,250);
	public void OnGUI(){
TextoAGuardar = GUI.TextArea (miTextArea,TextoAGuardar);
	}
}
