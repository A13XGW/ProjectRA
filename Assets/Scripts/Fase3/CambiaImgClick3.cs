using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CambiaImgClick3 : MonoBehaviour {
	public Canvas area;
	public Image imgPrincipal, imgSecundario;
	public Image img;
	public int ind;
	public GameObject canvasImg;
	public GameObject flota;
	public GameObject flotantes;
	public Image[] A = new Image[6];

	void Start() {
		img =gameObject.GetComponent<Image> ();
	
	}

	public void Clickea() {


			imgPrincipal.sprite = img.sprite;
		imgSecundario.sprite = img.sprite;
			
			canvasImg.GetComponent<CambiarImagen3> ().indice = ind;
			
			
			Image N = canvasImg.GetComponent<CambiarImagen3> ().fondo;
			
			N.transform.position = new Vector2 (img.transform.position.x, img.transform.position.y);
			if (ind == 0)
			{
			A [0].gameObject.SetActive (true);
			A [1].gameObject.SetActive (false);
			A [2].gameObject.SetActive (false);
			A [3].gameObject.SetActive (false);
			A [4].gameObject.SetActive (false);
			A [5].gameObject.SetActive (false);
			}
		if (ind == 1)
		{
			A [0].gameObject.SetActive (false);
			A [1].gameObject.SetActive (true);
			A [2].gameObject.SetActive (false);
			A [3].gameObject.SetActive (false);
			A [4].gameObject.SetActive (false);
			A [5].gameObject.SetActive (false);

		}
			if (ind == 2) 
			{
			A [0].gameObject.SetActive (false);
			A [1].gameObject.SetActive (false);
			A [2].gameObject.SetActive (true);
			A [3].gameObject.SetActive (false);
			A [4].gameObject.SetActive (false);
			A [5].gameObject.SetActive (false);
			}
			if (ind == 3) {
			A [0].gameObject.SetActive (false);
			A [1].gameObject.SetActive (false);
			A [2].gameObject.SetActive (false);
			A [3].gameObject.SetActive (true);
			A [4].gameObject.SetActive (false);
			A [5].gameObject.SetActive (false);

		}
			if (ind == 4) {
			A [0].gameObject.SetActive (false);
			A [1].gameObject.SetActive (false);
			A [2].gameObject.SetActive (false);
			A [3].gameObject.SetActive (false);
			A [4].gameObject.SetActive (true);
			A [5].gameObject.SetActive (false);

		}
			if (ind == 5) {
			A [0].gameObject.SetActive (false);
			A [1].gameObject.SetActive (false);
			A [2].gameObject.SetActive (false);
			A [3].gameObject.SetActive (false);
			A [4].gameObject.SetActive (false);
			A [5].gameObject.SetActive (true);

			//area.GetComponent<CapturarText>().ActivarTexto();

		}


		//canvasImg.GetComponent<CambiarImagen> ().indice = canvasImg.GetComponent<CambiarImagen> ().thumbs.Length;
	/*	if (canvasImg.GetComponent<CambiarImagen3> ().indice == canvasImg.GetComponent<CambiarImagen3> ().thumbs.Length-1) {
			area.GetComponent<CapturarText>().ActivarTexto();
		}*/
	}
}