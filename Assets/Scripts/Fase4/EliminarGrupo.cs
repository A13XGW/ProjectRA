using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EliminarGrupo : MonoBehaviour {
	public GameObject grupo;
	public GameObject panelGrid;
	public void OnButtonDown(){
		GameObject tmp = GameObject.FindWithTag (grupo.tag);
		if (tmp.tag == grupo.tag) {
			tmp.slots = tmp.slots-1;
			Destroy (grupo);
		}
			

	}
}
