using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CargarImgs : MonoBehaviour 
{
	public Texture2D[] animales, personas, objetos;
	public Image[] ianimales, ipersonas, iobjetos;

	public Image deacticvated;//Al agregar el grid layout al panel se vuelve imposible obtener el ancho y alto de la imagen contenida en este
	//por eso se crea esta imagen, bien podria buscar obtenerlos del grid layout pero da la misma
	public Image thumb;//Imagen de la cual se instancia las demas
	public Image obj;
	public Image thumbP;
	private Texture2D[] thumbs;//Arreglo donde se carga las imagenes
	public Image panel, panelO, panelP;//Panel padre de las imagenes
	public RectTransform rectPanel, rectPanelO, rectPanelP;//mismo que el panel
	public int imagenesCarrete=0, imagenesCarreteP=0, imagenesCarreteO=0;
	public Scrollbar barra, barraO, barraP;//para istuar siempre el scroll en el inicio
	// Use this for initialization
	void Start () {

		Rect rec;
		Vector2 vec = new Vector2 (0.5f, 0.5f);

		//carga la imagenes
		thumbs = Resources.LoadAll<Texture2D> ("Face2/Animales");
		rec = new Rect (0, 0, thumbs [0].width, thumbs [0].height);//instancia del tamaño de la iamgen
		vec = new Vector2 (0.5f, 0.5f);//pivote
		//asigna imagenes al objeto
		thumb.sprite = Sprite.Create (thumbs [0], rec, vec);//asignacion de la imagen inicial al objeto imagen
		Image[] images = new Image[thumbs.Length];
		//bucle para instancia iamgenes.
		float wid;
		wid = deacticvated.GetComponent<RectTransform> ().sizeDelta.x;
		for(int x=1; x<thumbs.Length; x++)
		{//Crece el panel de las imagenes
			rectPanel.sizeDelta = new Vector2 (rectPanel.sizeDelta.x + wid + 20 , rectPanel.sizeDelta.y);
		}
		for (int x=1; x<thumbs.Length; x++) {//Asinacion y posicion de imagenes 
			images [x] = Instantiate (thumb);
			imagenesCarrete++;
			rec = new Rect (0, 0, thumbs [x].width, thumbs [x].height);
			images [x].sprite = Sprite.Create (thumbs [x], rec, vec);
			images [x].transform.position = new Vector2 (thumb.transform.position.x + ((thumb.GetComponent<RectTransform> ().sizeDelta.x + (thumb.GetComponent<RectTransform> ().sizeDelta.x * 0.20f)) * x), thumb.transform.position.y);
			images [x].transform.SetParent (panel.transform);
			images [x].gameObject.GetComponent<RectTransform> ().localScale = new Vector3 (1.0f, 1.0f, 1.0f);
			images[x].GetComponent<ImagePanelViewer>().i = x;
		}
		imagenesCarrete++;
		//Debug.Log ("Objetos");
		//Objetos
		//thumbs = null;
		thumbs = Resources.LoadAll<Texture2D> ("Face2/Objetos");
		//asigna imagenes al objeto
		thumb = obj;
		//
		thumb.sprite = Sprite.Create (thumbs [0], rec, vec);//asignacion de la imagen inicial al objeto imagen
		Image[] imagesO = new Image[thumbs.Length];
		//bucle para instancia iamgenes.

		wid = deacticvated.GetComponent<RectTransform> ().sizeDelta.x;
		for(int x=1; x<thumbs.Length; x++)
		{//Crece el panel de las imagenes
			rectPanelO.sizeDelta = new Vector2 (rectPanelO.sizeDelta.x + wid + 20 , rectPanelO.sizeDelta.y);
		}
		for (int x=1; x<thumbs.Length; x++) {//Asinacion y posicion de imagenes 
			imagesO [x] = Instantiate (obj);
			imagenesCarreteO++;
			rec = new Rect (0, 0, thumbs [x].width, thumbs [x].height);
			imagesO [x].sprite = Sprite.Create (thumbs [x], rec, vec);
			imagesO [x].transform.position = new Vector2 (obj.transform.position.x + ((obj.GetComponent<RectTransform> ().sizeDelta.x + (obj.GetComponent<RectTransform> ().sizeDelta.x * 0.20f)) * x), obj.transform.position.y);
			imagesO [x].transform.SetParent (panelO.transform);
			imagesO [x].gameObject.GetComponent<RectTransform> ().localScale = new Vector3 (1.0f, 1.0f, 1.0f);
			imagesO [x].GetComponent<ImagePanelViewer>().i = x;
		}
		imagenesCarreteO++;

//		Debug.Log ("Personas");
		//Personas
		thumbs = Resources.LoadAll<Texture2D> ("Face2/Personas");
		//asigna imagenes al objeto
		thumbP.sprite = Sprite.Create (thumbs [0], rec, vec);//asignacion de la imagen inicial al objeto imagen
		Image[] imagesP = new Image[thumbs.Length];
		//bucle para instancia iamgenes.
		
		wid = deacticvated.GetComponent<RectTransform> ().sizeDelta.x;
		for(int x=1; x<thumbs.Length; x++)
		{//Crece el panel de las imagenes
			rectPanelP.sizeDelta = new Vector2 (rectPanelP.sizeDelta.x + wid + 20 , rectPanelP.sizeDelta.y);
		}
		for (int x=1; x<thumbs.Length; x++) {//Asinacion y posicion de imagenes 
			imagesP [x] = Instantiate (thumbP);
			imagenesCarreteP++;
			rec = new Rect (0, 0, thumbs [x].width, thumbs [x].height);
			imagesP [x].sprite = Sprite.Create (thumbs [x], rec, vec);
			imagesP [x].transform.position = new Vector2 (thumbP.transform.position.x + ((thumbP.GetComponent<RectTransform> ().sizeDelta.x + (thumbP.GetComponent<RectTransform> ().sizeDelta.x * 0.20f)) * x), thumbP.transform.position.y);
			imagesP [x].transform.SetParent (panelP.transform);
			imagesP [x].gameObject.GetComponent<RectTransform> ().localScale = new Vector3 (1.0f, 1.0f, 1.0f);
			imagesP [x].GetComponent<ImagePanelViewer>().i = x;
		}
		imagenesCarreteP++;
		StartCoroutine(Espera(0.01F));
	}
	IEnumerator Espera(float waitTime) {
		yield return new WaitForSeconds(waitTime);//ScrollBars a posicion inicial
		barra.value = 0;
		barraO.value = 0;
		barraP.value = 0;
	}
}
