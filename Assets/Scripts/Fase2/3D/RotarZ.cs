using UnityEngine;
using System.Collections;

public class RotarZ : MonoBehaviour {

	void OnMouseUp() {
		transform.GetComponent<MoverRotarObjeto3d>().objeto.transform.rotation = Quaternion.Euler (GetComponent<MoverRotarObjeto3d>().objeto.transform.rotation.x, GetComponent<MoverRotarObjeto3d>().objeto.transform.rotation.y, GetComponent<MoverRotarObjeto3d>().objeto.transform.rotation.z+1);			
	}
}
