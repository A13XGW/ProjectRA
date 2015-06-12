using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NuevoGrupo : MonoBehaviour {
	public GameObject grupo;
	public Transform canvas;
	public void OnButtonDown(){
		grupo.SetActive (true);
		GameObject tmp = Instantiate (grupo);
		tmp.transform.SetParent (canvas);
		grupo.SetActive (false);
	}
}
