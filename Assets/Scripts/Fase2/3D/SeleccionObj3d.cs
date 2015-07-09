using UnityEngine;
using System.Collections;

public class SeleccionObj3d : MonoBehaviour {
	public GameObject objeto;
	public MoverRotarObjeto3d moverObj3d;
	public SeleccionDeColor Paleta;

	void Start() {
		moverObj3d = objeto.GetComponent<MoverRotarObjeto3d> ();
		Paleta = objeto.GetComponent<SeleccionDeColor> ();
	}
	void OnMouseUp() {
		moverObj3d.objeto = transform.gameObject;

	}
	void OnMouseDown(){
		Paleta.objeto = transform.gameObject;
	}

}
