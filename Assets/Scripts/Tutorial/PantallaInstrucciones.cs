using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class PantallaInstrucciones : MonoBehaviour {

	public GameObject panelInstrucciones;
	public Text texto;
	public string ruta;
	public string archivo;
	// Use this for initialization
	void Start () {
		if (Application.loadedLevelName == "Fase1") {
			archivo = "Fase1.txt";
		}
		if (Application.loadedLevelName == "Fase2") {
			archivo = "Fase2.txt";
		}
		panelInstrucciones.SetActive (true);
		ruta = "./Assets/Resources/Tutorial/"; 
		ruta += archivo;
		texto.text = File.ReadAllText (ruta);
	}
	public void boton(){
		panelInstrucciones.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
