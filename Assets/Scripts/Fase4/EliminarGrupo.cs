using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EliminarGrupo : MonoBehaviour {
	public GameObject grupo;
	public void OnButtonDown(){
		if (grupo.GetComponent<Drop>().slots == 1) {
			Destroy(grupo);
		}
	}
}
