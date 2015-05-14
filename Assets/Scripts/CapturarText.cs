using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class CapturarText : MonoBehaviour {
	public string[] TextoAGuardar;
	public InputField CampoTexto;

	public void ActivarTexto (){
		CampoTexto.gameObject.SetActive (true);
	}
	void Start(){
		TextoAGuardar = new string[50];
	}
	public void guardar(){
		string ruta;
		ruta = Application.dataPath;
		ruta += "/Resources/Comentarios/Comentario.txt";
		System.IO.File.WriteAllLines (ruta, TextoAGuardar, System.Text.Encoding.UTF8);

	}
	void Update(){
		int i = 0;
		do{
			TextoAGuardar[i] = CampoTexto.text;
			i++;
		}while(Input.GetKeyDown ("intro"));
	}
}