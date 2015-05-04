using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GeneraNuevasFotos : MonoBehaviour {

	public GameObject objetoBaseFoto1;
	public GameObject objetoBaseFoto2;
	public Sprite fx;
	public Sprite xd;
	public Image imagen2;

	void Start () {
	
		imagen2=objetoBaseFoto2.GetComponent<Image> ();
		imagen2.sprite = xd;
	//	imagenes=objetoBaseFoto.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
