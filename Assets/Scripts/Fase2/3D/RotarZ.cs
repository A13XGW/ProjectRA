using UnityEngine;
using System.Collections;
using System;
public class RotarZ : MonoBehaviour {
	public GameObject objeto;//Es el que selecciona con el click de cualquier herramienta
	public void OnMouseUp() {
		objeto.transform.Rotate (Vector3.back*5);
	}
}
