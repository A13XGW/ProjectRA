using UnityEngine;
using System.Collections;

public class RotarX : MonoBehaviour {
	public GameObject objeto;
	public GameObject moverObj3d;
	
	void Start() {
		moverObj3d = objeto.GetComponent<MoverRotarObjeto3d> ().objeto;
	}
	void OnMouseDown() {
		//moverObj3d.objeto = transform.gameObject;
		moverObj3d.transform.rotation = Quaternion.Euler (moverObj3d.transform.rotation.x, moverObj3d.transform.rotation.y-1, moverObj3d.transform.rotation.z);		
	}
}
