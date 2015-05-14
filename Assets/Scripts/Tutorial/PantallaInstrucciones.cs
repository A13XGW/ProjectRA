using UnityEngine;
using System.Collections;

public class PantallaInstrucciones : MonoBehaviour {

	public GameObject panelInstrucciones;

	// Use this for initialization
	void Start () {
		panelInstrucciones.SetActive (true);

	}
	public void boton(){
		panelInstrucciones.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
