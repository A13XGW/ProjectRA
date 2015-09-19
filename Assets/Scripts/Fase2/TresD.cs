using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TresD : MonoBehaviour {
	public GameObject tresD, dosD;
	int bandera;
	// Use this for initialization
	void Start(){
		bandera = 0;
	}
	public void OnButtonDown(){
		if (bandera == 0) {
			tresD.SetActive (true);
			dosD.SetActive (false);
			bandera = 1;
			transform.GetComponentInChildren<Text>().text = "2D";
		} else {
			tresD.SetActive (false);
			dosD.SetActive (true);
			bandera = 0;
			transform.GetComponentInChildren<Text>().text = "3D";
		}

	}
}
