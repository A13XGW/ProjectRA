using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ResaltarSemantica : MonoBehaviour {

	public Image colorSeleccion;
	private int clicks = 0;

	// Use this for initialization
	public void OnMouseDown(){
		clicks ++;
		switch (clicks) {
		case 1:
			colorSeleccion.color= new Color (255,0,0);
			break;
		case 2:
			colorSeleccion.color = new Color (0,255,0);
			break;
		case 3:
			colorSeleccion.color = new Color (0,0,255);
			break;
		case 4:
			colorSeleccion.color = new Color (0,255,255);
			break;
		case 5:
			colorSeleccion.color = new Color (255,0,255);
			break;
		case 6:
			colorSeleccion.color = new Color (255,255,0);
			clicks =0;
			break;
		}

	}
	// Update is called once per frame
	void Update () {
	
	}
}
