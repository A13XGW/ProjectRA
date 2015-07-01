using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DeleteAlert : MonoBehaviour {
	public GameObject alerta;

	public void OnMouseDown(){
		alerta.SetActive (false);
		Destroy (alerta);
	}
}
