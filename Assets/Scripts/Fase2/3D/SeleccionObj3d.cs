using UnityEngine;
using System.Collections;

public class SeleccionObj3d : MonoBehaviour {
	public GameObject objeto;
	public MoverRotarObjeto3d moverObj3d;
	//public MoverRotarObjeto3d flechas;

	void Start() {
		moverObj3d = objeto.GetComponent<MoverRotarObjeto3d> ();
		//flechas = objeto.GetComponent<MoverRotarObjeto3d> ();
	}
	void OnMouseUp() {
		moverObj3d.objeto = transform.gameObject;
		//flechas.flecha = transform.GetChild(0).gameObject;

	}

}
