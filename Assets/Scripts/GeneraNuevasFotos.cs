using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GeneraNuevasFotos : MonoBehaviour {
	public Transform GeneradorDeImagenes;
	public GameObject objetoBaseFoto1;
	public GameObject objetoBaseFoto2;
	public Sprite fx;
	public Sprite xd;
	public float posicionGenX;
	//selecion de objeto mediante TAg falta implementar, erro con la instanciacion no se porque
	void Start () {
		posicionGenX = GeneradorDeImagenes.transform.position.x;
		for(int i = 0; i<= 4; i++){
			posicionGenX = posicionGenX - 60f;
			Instantiate(objetoBaseFoto1, GeneradorDeImagenes.position);
			GeneradorDeImagenes.transform.position = new Vector3 (posicionGenX,-43,0);
		}
//		imagen2=objetoBaseFoto2.GetComponent<Image> ();
		//imagen2.sprite = xd;
	//	imagenes=objetoBaseFoto.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
