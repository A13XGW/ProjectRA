using UnityEngine;
using System.Collections;

public class RotarY : MonoBehaviour {

	void OnMouseUp() {
		transform.GetComponent<MoverRotarObjeto3d>().objeto.transform.rotation = Quaternion.Euler (GetComponent<MoverRotarObjeto3d>().objeto.transform.rotation.x+1, GetComponent<MoverRotarObjeto3d>().objeto.transform.rotation.y, GetComponent<MoverRotarObjeto3d>().objeto.transform.rotation.z);		
	}
}
