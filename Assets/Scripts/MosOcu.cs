using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MosOcu : MonoBehaviour {

	public Image GroupInputField;
	public Canvas area;
	public float sizePH ;
	public float sizePW;

	void Start () {
		//sizePW = area.GetComponent<RectTransform>().sizeDelta.x;
		sizePW = GroupInputField.GetComponent<RectTransform> ().position.x;
		Debug.Log (sizePW);
		sizePH = area.GetComponent<RectTransform>().position.y * 2 + (area.GetComponent<RectTransform>().position.y/3);
		Debug.Log (sizePH);
	}
	public void OcultarObjeto(){
		GroupInputField.GetComponent<RectTransform> ().position = new Vector2 (sizePW,sizePH);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
