using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CambiarImagen : MonoBehaviour {
	//Emmanuel
	public Image objetoImagen;
	public int indice=1;
	public Scrollbar barra;
	public int i = 0;
	public Canvas area;
	public RectTransform rectPanel;
	public GameObject ImagenS;
	public RectTransform rectImagen;
	public Image Difuminado;
	public Image[] Difinsta;
//	Vector3 diferencia = new Vector3(1,1,1);
	//Emmanuel
	//Alex
	public Image fondo;
	public Image thumb;
	public Texture2D[] thumbs;
	public Image panel;
	public Image[] images;
	public GameObject panelS;
	//Alex
	
	// Use this for initialization
	void Start() {
		DontDestroyOnLoad (GameObject.FindGameObjectWithTag("AvatarI"));
		thumbs = Resources.LoadAll<Texture2D>("Fase1");
		
		Rect rec = new Rect (0, 0, thumbs [0].width, thumbs [0].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		thumb.sprite = Sprite.Create (thumbs [0], rec, vec);
		//Emmanuel
		objetoImagen.sprite = Sprite.Create (thumbs [0], rec, vec);
		
		//Alex
		images = new Image[thumbs.Length];
		Difinsta = new Image[thumbs.Length];
		//Debug.Log (images);
		for (int x=1; x<thumbs.Length; x++) {
			rectPanel = panelS.GetComponent<RectTransform> ();
			rectPanel.sizeDelta = new Vector2 (rectPanel.sizeDelta.x+(thumb.GetComponent<RectTransform>().sizeDelta.x + (thumb.GetComponent<RectTransform>().sizeDelta.x * 0.25f)), rectPanel.sizeDelta.y);
			images[x] = Instantiate(thumb);
			rec = new Rect (0, 0, thumbs [x].width, thumbs [x].height);
			images[x].sprite = Sprite.Create (thumbs [x], rec, vec);
			images[x].transform.position = new Vector2 (thumb.transform.position.x + ((thumb.GetComponent<RectTransform>().sizeDelta.x + (thumb.GetComponent<RectTransform>().sizeDelta.x * 0.25f))*x), thumb.transform.position.y);
			images[x].transform.SetParent(panel.transform);
			images[x].gameObject.GetComponent<RectTransform>().localScale = new Vector3(1.0f,1.0f,1.0f);
			//agregar
			images[x].GetComponent<CambiaImgClick>().ind=x;

			/*Difinsta[x] = Instantiate(Difuminado);
			rec = new Rect (0, 0, thumbs [x].width, thumbs [x].height);
			Difinsta[x].transform.position = new Vector2 (images[x].transform.position.x,images[x].transform.position.y);
			Difinsta[x].transform.SetParent(images[x].transform);
			//Difinsta[x].transform.SetParent(panel.transform);
			Difinsta[x].gameObject.GetComponent<RectTransform>().localScale = new Vector3(1.0f,1.0f,1.0f);*/

		}
		fondo.transform.position = thumb.transform.position;
		Difuminado.gameObject.SetActive (false);
	}
	//Alex

	public void Avanza () {
		if (indice < thumbs.Length-1) {
			fondo.transform.position = images[indice+1].transform.position;
			indice++;
		} 
		if(indice < thumbs.Length){
			images[indice].GetComponent<CambiaImgClick>().difuminado.SetActive(false);
		}
		if (indice < thumbs.Length) {
			Rect rec = new Rect (0, 0, thumbs [indice].width, thumbs [indice].height);
			Vector2 vec = new Vector2 (0.5f, 0.5f);

			objetoImagen.sprite = Sprite.Create (thumbs [indice], rec, vec);
		}
		if (indice == thumbs.Length-1) {
			area.GetComponent<CapturarText>().ActivarTexto();
		} 


		if (i == thumbs.Length / 4) {
			barra.value += 0.25f;
			i = 1;
		}
		i++;

		thumb.GetComponent<CambiaImgClick> ().ind = indice;
	}
	
	public void Retrocede() {
		indice--;
		if (indice > 0) {
			fondo.transform.position = images [indice].transform.position;
			thumb.GetComponent<CambiaImgClick> ().ind = indice;
			Rect rec = new Rect (0, 0, thumbs [indice].width, thumbs [indice].height);
			Vector2 vec = new Vector2 (0.5f, 0.5f);
			objetoImagen.sprite = Sprite.Create (thumbs [indice], rec, vec); 
			images[indice].GetComponent<CambiaImgClick>().difuminado.SetActive(false);


		} else {
			indice=0;
			fondo.transform.position = thumb.transform.position;
			thumb.GetComponent<CambiaImgClick> ().ind = indice;
			Rect rec = new Rect (0, 0, thumb.mainTexture.width, thumb.mainTexture.height);
			Vector2 vec = new Vector2 (0.5f, 0.5f);
			objetoImagen.sprite = Sprite.Create (thumbs [indice], rec, vec); 
		}
		if (i == thumbs.Length / 4) {
			barra.value -= 0.25f;
			i = 1;
		}
		i++;
		/*thumb.GetComponent<CambiaImgClick> ().ind = indice;
		Rect rec = new Rect (0, 0, thumbs [indice].width, thumbs [indice].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		objetoImagen.sprite = Sprite.Create (thumbs [indice], rec, vec); */
		
	}
}
