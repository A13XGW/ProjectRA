using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class Faltantes : MonoBehaviour {
	public Text Faltante;
	public GameObject canvas;
	public GameObject scrollImages;
	// Update is called once per frame
	void Update () {
		Faltante.text = "Faltan: " + Convert.ToString(canvas.GetComponent<CargarImagenes> ().imagenesCarrete);
		if (canvas.GetComponent<CargarImagenes> ().imagenesCarrete == 0) {
			scrollImages.SetActive (false);
		}
	}
}
