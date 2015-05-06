using UnityEngine;
using UnityEngine.UI;
using System.Collections;

using UnityEditor;

public class CambiarImagen : MonoBehaviour {

	public Image objetoImagen;
	public Image[] brillo;
	public Sprite amarillo;
	public Sprite transparente;
	public Sprite[] imagenes;
	public int indice=0;
	public int longitud;
	public Image[] carrete;
	public Scrollbar barra;

	//-----------------------------
	public Texture2D[] thumbs;
	//-----------------------------
	// Use this for initialization
	
	void Start() {
		objetoImagen.sprite = imagenes [0];

		for (int i=0; i<=longitud; i++) {
			brillo [i].sprite = transparente;
			carrete [i].sprite = imagenes [i];
		}
			brillo [0].sprite = amarillo;

		//-------------------------------------
		thumbs = Resources.LoadAll<Texture2D>("Images");
		for (int i=0; i<=longitud; i++) {
			brillo [i].sprite = transparente;
			brillo [0].sprite = amarillo;
			Rect rec = new Rect (0, 0, thumbs [i].width, thumbs [i].height);
			Vector2 vec = new Vector2 (0.5f, 0.5f);
			carrete [i].sprite = Sprite.Create (thumbs [i], rec, vec);
		}

		EditorUtility.DisplayDialog(thumbs.Length.ToString(), "Seguro que deseas continuar?", "Si", "No");
		//-------------------------------------
		
	}
	// Update is called once per frame
	public void Avanza () {
		brillo [indice].sprite = transparente;
		if (indice < longitud) {
			indice++;
			//objPan.position = new Vector2(objPan.position.x + 55,objPan.position.y);
		}
		if(indice == 6){
			barra.value =  0.70248f;
		}
		if(indice == 12 ){
			barra.value =  1f;
		}

		brillo [indice].sprite = amarillo;
		//-------------------------------------
		Rect rec = new Rect (0, 0, thumbs [indice].width, thumbs [indice].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		objetoImagen.sprite = Sprite.Create (thumbs [indice], rec, vec); 
		//-------------------------------------
	}
	
	public void Retrocede() {
		brillo [indice].sprite = transparente;
		if (indice > 0) {
			indice--;
			//objPan.position = new Vector2(objPan.position.x-55,objPan.position.y);
		}
		if(indice == 6){
			barra.value =  0f;
		}
		if(indice == 12 ){
			barra.value =  .70248f;
		}
		brillo [indice].sprite = amarillo;
		//-------------------------------------
		Rect rec = new Rect (0, 0, thumbs [indice].width, thumbs [indice].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		objetoImagen.sprite = Sprite.Create (thumbs [indice], rec, vec); 
		//-------------------------------------

	}
}
