using UnityEngine;
using System.Collections;

public class SeleccionObj3d : MonoBehaviour {
	public GameObject objeto;
	public MoverRotarObjeto3d moverObj3d;

	void Start() {
		moverObj3d = objeto.GetComponent<MoverRotarObjeto3d> ();
	}
	void OnMouseUp() {
		moverObj3d.objeto = transform.gameObject;
	}

}
