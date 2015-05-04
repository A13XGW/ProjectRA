using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Inicio : MonoBehaviour {
	public Text texto;
	public Image imagen;

	// Use this for initialization
	void Start () {
		texto.text = "Hola mundo";
		Object[] imagenes = Resources.LoadAll ("Resources");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
