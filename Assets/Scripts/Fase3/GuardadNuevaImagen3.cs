using UnityEngine;
using System.Collections;

public class GuardadNuevaImagen3: MonoBehaviour {
	public int imagen = 1;
	public string ruta;
	public GameObject flechaD;
	public GameObject flechaI;
	public GameObject ScrollView;
	public float desvanecer =0f ;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//desvanecer = Time.deltaTime;
		if (desvanecer >= 3f) {
			flechaD.SetActive (false);
			flechaI.SetActive (false);
			ScrollView.SetActive (false);
		}
	}
	void OnMouseUp(){
		desvanecer = Time.deltaTime;
		//desvanecer = 0f;
		flechaD.SetActive (true);
		flechaI.SetActive (true);
		ScrollView.SetActive (true);
	}
	public void GuardarImagen(){
		ruta = string.Concat ("assets/sources/NuevaImage",imagen,".jpg");
		imagen++;
		Application.CaptureScreenshot(ruta);
			}
}
