using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EliminarGrupo : MonoBehaviour {
	public GameObject grupo;
	public GameObject panelGrid;
	public GameObject alerta;
	public GameObject canvas;
	public void OnButtonDown(){
		if (grupo.GetComponent<DragGroup> ().slots == 1) {
			Destroy (grupo);
		} else {
			alerta.SetActive(true);
			GameObject tmp = Instantiate(alerta);
			alerta.SetActive(false);
			tmp.transform.SetParent(canvas.transform);
			tmp.transform.position = new Vector2(Screen.width/2,Screen.height/2);
			//Alerta con que todavia tiene imagenes
		}

	}
}