using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CargarImagenes : MonoBehaviour {
	public Image deacticvated;//Al agregar el grid layout al panel se vuelve imposible obtener el ancho y alto de la imagen contenida en este
	//por eso se crea esta imagen, bien podria buscar obtenerlos del grid layout pero da la misma xD
	public Image thumb;
	private Texture2D[] thumbs;
	public Image panel;
	public RectTransform rectPanel;
	public int imagenesCarrete=0;
	public GameObject guardar;
	public Scrollbar barra;
	// Use this for initialization
	void Start () {
		//carga la imagenes
		thumbs = Resources.LoadAll<Texture2D> ("Fase4");
		Rect rec = new Rect (0, 0, thumbs [0].width, thumbs [0].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		//asigna imagenes al objeto
		thumb.sprite = Sprite.Create (thumbs [0], rec, vec);
		Image[] images = new Image[thumbs.Length];
		//bucle para instancia iamgenes.
		float wid;
		wid = deacticvated.GetComponent<RectTransform> ().sizeDelta.x;
		for(int x=1; x<thumbs.Length; x++)
		{
			rectPanel.sizeDelta = new Vector2 (rectPanel.sizeDelta.x + wid + wid*0.28f , rectPanel.sizeDelta.y);
			rectPanel.sizeDelta = new Vector2 (rectPanel.sizeDelta.x + (thumb.GetComponent<RectTransform> ().sizeDelta.x + (thumb.GetComponent<RectTransform> ().sizeDelta.x * 0.20f)), rectPanel.sizeDelta.y);
			//Debug.Log(rectPanel.sizeDelta);
		}
		for (int x=1; x<thumbs.Length; x++) {
			images [x] = Instantiate (thumb);
			imagenesCarrete++;
			rec = new Rect (0, 0, thumbs [x].width, thumbs [x].height);
			images [x].sprite = Sprite.Create (thumbs [x], rec, vec);
			images [x].transform.position = new Vector2 (thumb.transform.position.x + ((thumb.GetComponent<RectTransform> ().sizeDelta.x + (thumb.GetComponent<RectTransform> ().sizeDelta.x * 0.20f)) * x), thumb.transform.position.y);
			images [x].transform.SetParent (panel.transform);
			images [x].gameObject.GetComponent<RectTransform> ().localScale = new Vector3 (1.0f, 1.0f, 1.0f);

		}
		imagenesCarrete++;
		StartCoroutine(Espera(0.01F));
	}
	IEnumerator Espera(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		barra.value = 0;
	}
	// Update is called once per frame
	void Update () {
	if (imagenesCarrete == 0) {
			guardar.SetActive(true);
		}
	}
}
