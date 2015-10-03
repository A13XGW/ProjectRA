using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bandera : MonoBehaviour {
	public GameObject panelCorteTipos;
	public int bandera;
	public Button[] boton;
	// Use this for initialization
	void Start () {
		bandera = 0;
		boton = GetComponentsInChildren<Button>();
	}
	
	// Update is called once per frame
	public void OpcionActual (int opt) {
		bandera = opt;
	}
}
