using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MosOcu : MonoBehaviour {

	public Scrollbar barra;

	void Start () {
	}
	public void OcultarObjeto(){
//		GroupInputField.GetComponent<RectTransform> ().position = new Vector2 (sizePW,sizePH);

		if (barra.value == 0) {
			barra.value = 1;
		} else {
			barra.value = 0;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
