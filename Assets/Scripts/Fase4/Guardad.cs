using UnityEngine;
using System.Collections;
using System.IO;

public class Guardad : MonoBehaviour {
	int contador=0;
	string ruta;
	public GameObject Comentarios;
	public GameObject CapturoPantalla;
	public void OnButtonDown(){
		contador ++;
		ruta = Application.persistentDataPath;
		ruta += "/Resources/Screenshot_Fase4/";
		Directory.CreateDirectory (ruta);
		ruta += "Screenshot"+contador;
		ruta += ".png";
		Debug.Log (ruta);
		Application.CaptureScreenshot(ruta);
		//Agregar timer
		//Thread.Sleep (20000);
		StartCoroutine(Espera(1.25F));
		//CapturoPantalla.SetActive (true);

	}


IEnumerator Espera(float waitTime) {
		Debug.Log (Time.time);
		yield return new WaitForSeconds(waitTime);
		Debug.Log (Time.time);
	//LA LINEA SIGUIENTE SE DEBE QUITAR CUANDO HAYA COMENTARIOS ACTIVADOS Y LA PANTALLA QUE SE DEBE ENVIAR
	//SERA LA DE COMENTARIOS
		CapturoPantalla.SetActive (true);
	//CapturoPantalla.SetActive (false);
	

}

	public void comentar()
	{
		Comentarios.SetActive (true);
	}

}