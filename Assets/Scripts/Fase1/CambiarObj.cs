using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CambiarObj : MonoBehaviour {

	public GameObject panelObj;
	public RectTransform rectPanel;
	// Use this for initialization
	void Start () {
		rectPanel = panelObj.GetComponent<RectTransform> ();
		rectPanel.sizeDelta = new Vector2 (rectPanel.sizeDelta.x+55, rectPanel.sizeDelta.y);//crece el pnael de las imagenes
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
