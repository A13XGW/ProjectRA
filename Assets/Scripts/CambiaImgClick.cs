using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CambiaImgClick : MonoBehaviour {
	public Canvas area;
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

			Image N = canvasImg.GetComponent<CambiarImagen> ().fondo;

			N.transform.position = new Vector2 (img.transform.position.x, img.transform.position.y);

		//canvasImg.GetComponent<CambiarImagen> ().indice = canvasImg.GetComponent<CambiarImagen> ().thumbs.Length;
		if (canvasImg.GetComponent<CambiarImagen> ().indice == canvasImg.GetComponent<CambiarImagen> ().thumbs.Length-1) {
			area.GetComponent<CapturarText>().ActivarTexto();
		}
	}
}