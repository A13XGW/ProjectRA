using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CambiarImagen3 : MonoBehaviour {

	public Image objetoImagen;
	public int indice=0;
	public Scrollbar barra;
	public int i = 0;
	public Canvas area;
	public GameObject panelS;
	public RectTransform rectPanel;
	public GameObject ImagenS;
	public RectTransform rectImagen;


	public Image fondo;
	public Image thumb;
	public Texture2D[] thumbs;
	public Image thumbF;
	public Texture2D[] thumbsF;
	public Image panel;
	public Image flotantes;

	public Image[] imges = new Image[6];

	void Start() {

		thumbs = Resources.LoadAll<Texture2D>("Fase3");
		
		Rect rec = new Rect (0, 0, thumbs [0].width, thumbs [0].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		thumb.sprite = Sprite.Create (thumbs [0], rec, vec);

		objetoImagen.sprite = Sprite.Create (thumbs [0], rec, vec);


		Image[] images = new Image[thumbs.Length];
		for (int x=1; x<thumbs.Length; x++) {
			rectPanel = panelS.GetComponent<RectTransform> ();
			rectPanel.sizeDelta = new Vector2 (rectPanel.sizeDelta.x+(thumb.GetComponent<RectTransform>().sizeDelta.x + (thumb.GetComponent<RectTransform>().sizeDelta.x * 0.20f))/*+84*/, rectPanel.sizeDelta.y);
			images[x] = Instantiate(thumb);
			rec = new Rect (0, 0, thumbs [x].width, thumbs [x].height);
			images[x].sprite = Sprite.Create (thumbs [x], rec, vec);
			images[x].transform.position = new Vector2 (thumb.transform.position.x + ((thumb.GetComponent<RectTransform>().sizeDelta.x + (thumb.GetComponent<RectTransform>().sizeDelta.x * 0.2f))*x), thumb.transform.position.y);
			images[x].transform.SetParent(panel.transform);
			images[x].gameObject.GetComponent<RectTransform>().localScale = new Vector3(1.0f,1.0f,1.0f);
			//agregar
			images[x].GetComponent<CambiaImgClick3>().ind=x;

		}


	}

	public void Avanza () {
	/*	if (indice >= 0 && indice < ) {
			indice++;
		}*/

		if (indice < thumbs.Length-1) 
		{
			fondo.transform.position = new Vector2 (fondo.transform.position.x + 66, fondo.transform.position.y);
			indice++;
		} 

		if (indice < thumbs.Length) {
			Rect rec = new Rect (0, 0, thumbs [indice].width, thumbs [indice].height);
			Vector2 vec = new Vector2 (0.5f, 0.5f);
			objetoImagen.sprite = Sprite.Create (thumbs [indice], rec, vec);
		}
		if (indice == thumbs.Length-1) {
//			area.GetComponent<CapturarText>().ActivarTexto();
		} 


		if (i == thumbs.Length / 4) {
			barra.value += 0.25f;
			i = 1;
		}
		i++;



		//thumb.GetComponent<CambiaImgClick3> ().ind = indice;

		if (indice == 0) 
		{

			imges [0].gameObject.SetActive (true);
			imges [1].gameObject.SetActive (false);
			imges [2].gameObject.SetActive (false);
			imges [3].gameObject.SetActive (false);

		}
		if (indice == 1) 
		{
			imges [0].gameObject.SetActive (false);
			imges [1].gameObject.SetActive (true);
			imges [2].gameObject.SetActive (false);
			imges [3].gameObject.SetActive (false);

		}
		if (indice == 2) 
		{
			imges [0].gameObject.SetActive (false);
			imges [1].gameObject.SetActive (false);
			imges [2].gameObject.SetActive (true);
			imges [3].gameObject.SetActive (false);

		}
		if (indice == 3) 
		{
			imges [0].gameObject.SetActive (false);
			imges [1].gameObject.SetActive (false);
			imges [2].gameObject.SetActive (false);
			imges [3].gameObject.SetActive (true);

		}
		if (indice == 4) 
		{
			imges [0].gameObject.SetActive (false);
			imges [1].gameObject.SetActive (false);
			imges [2].gameObject.SetActive (false);
			imges [3].gameObject.SetActive (false);

		}
		if (indice == 5) 
		{
			imges [0].gameObject.SetActive (false);
			imges [1].gameObject.SetActive (true);
			imges [2].gameObject.SetActive (false);
			imges [3].gameObject.SetActive (false);

		}

	

	}
	
	public void Retrocede() 
	{

		if (indice > 0) {
			fondo.transform.position = new Vector2 (fondo.transform.position.x-66, fondo.transform.position.y);
			indice--;

		}
		if (i == thumbs.Length / 4) {
			barra.value -= 0.25f;
			i = 1;
		}
		i++;


		Rect rec = new Rect (0, 0, thumbs [indice].width, thumbs [indice].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		objetoImagen.sprite = Sprite.Create (thumbs [indice], rec, vec); 


		if (indice == 0) 
		{
			imges [0].gameObject.SetActive (true);
			imges [1].gameObject.SetActive (false);
			imges [2].gameObject.SetActive (false);
			imges [3].gameObject.SetActive (false);

		}
		if (indice == 1) 
		{
			imges [0].gameObject.SetActive (false);
			imges [1].gameObject.SetActive (true);
			imges [2].gameObject.SetActive (false);
			imges [3].gameObject.SetActive (false);

		}
		if (indice == 2) 
		{
			imges [0].gameObject.SetActive (false);
			imges [1].gameObject.SetActive (false);
			imges [2].gameObject.SetActive (true);
			imges [3].gameObject.SetActive (false);
		
		}
		if (indice == 3) 
		{
			imges [0].gameObject.SetActive (false);
			imges [1].gameObject.SetActive (false);
			imges [2].gameObject.SetActive (false);
			imges [3].gameObject.SetActive (true);

		}
		if (indice == 4) 
		{
			imges [0].gameObject.SetActive (false);
			imges [1].gameObject.SetActive (false);
			imges [2].gameObject.SetActive (false);
			imges [3].gameObject.SetActive (false);

		}
		if (indice == 5) 
		{
			imges [0].gameObject.SetActive (false);
			imges [1].gameObject.SetActive (false);
			imges [2].gameObject.SetActive (false);
			imges [3].gameObject.SetActive (false);
		
		}


	}
}
