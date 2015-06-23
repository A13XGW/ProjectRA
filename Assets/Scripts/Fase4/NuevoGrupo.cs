using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NuevoGrupo : MonoBehaviour {
	public GameObject grupo;
	public Transform canvas;
	private int contador=1;
	public void OnButtonDown(){
		grupo.SetActive (true);
		GameObject tmp = Instantiate (grupo);
		tmp.transform.SetParent (canvas);
		tmp.transform.position = new Vector2(Screen.width/2,Screen.height/2);
		tmp.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
		//Debug.Log (tagGrupo);
		contador++;
		grupo.SetActive (false);
	}
}
