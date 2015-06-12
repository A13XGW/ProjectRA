using UnityEngine;
using System.Collections;
using System.IO;
public class Guardad : MonoBehaviour {
	int contador=0;
	string ruta;
	public GameObject Comentarios;
	public void OnButtonDown(){
		contador ++;
		ruta = Application.persistentDataPath;
		ruta += "/Resources/Screenshot_Fase4/";
		Directory.CreateDirectory (ruta);
		ruta += "Screenshot"+contador;
		ruta += ".png";
		Debug.Log (ruta);
		Application.CaptureScreenshot(ruta);
		Comentarios.SetActive (true);
	}
}
