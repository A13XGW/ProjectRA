using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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
	// Use this for initialization
	
	void Start() {
		objetoImagen.sprite = imagenes [0];
		for (int i=0; i<=longitud; i++) {
			brillo [i].sprite = transparente;
			carrete [i].sprite = imagenes [i];
		}
			brillo [0].sprite = amarillo;

		
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
		objetoImagen.sprite = imagenes [indice]; 
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
		objetoImagen.sprite = imagenes [indice]; 

	}
}
