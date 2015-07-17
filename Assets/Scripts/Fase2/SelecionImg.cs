using UnityEngine;
using System.Collections;

public class SelecionImg : MonoBehaviour {
	public GameObject objeto;
	public MoverRotarObjeto3d moverObj3d;

	void Start() {
		moverObj3d = objeto.GetComponent<MoverRotarObjeto3d> ();
	}
	void OnMouseDown() {
		moverObj3d.objeto = transform.gameObject;
		//objeto.GetComponent<gestures>().objeto = transform.gameObject;
	}
}
