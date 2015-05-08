using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CambiaImgClick : MonoBehaviour {

	public Image imgPrincipal;
	public Image img;
	public int ind=0;
	public GameObject canvasImg;
	void Start() {
		img =gameObject.GetComponent<Image> ();
	}

	public void Clickea() {
			imgPrincipal.sprite = img.sprite;
			canvasImg.GetComponent<CambiarImagen> ().indice = ind;
			
	}
}
