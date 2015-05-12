using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CambiarImagen : MonoBehaviour {
	
	public Image objetoImagen;
	public int indice=0;
	public Scrollbar barra;
	public int i = 0;
	//-----------------------------
	public Image fondo;
	public Image thumb;
	public Texture2D[] thumbs;
	public Image panel;
	
	//-----------------------------
	
	// Use this for initialization
	void Start() {
		thumbs = Resources.LoadAll<Texture2D>("Fase1");
		
		Rect rec = new Rect (0, 0, thumbs [0].width, thumbs [0].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		thumb.sprite = Sprite.Create (thumbs [0], rec, vec);
		objetoImagen.sprite = Sprite.Create (thumbs [0], rec, vec);

		Image[] images = new Image[thumbs.Length];
		for (int x=1; x<thumbs.Length; x++) {
			images[x] = Instantiate(thumb);
			rec = new Rect (0, 0, thumbs [x].width, thumbs [x].height);
			images[x].sprite = Sprite.Create (thumbs [x], rec, vec);
			images[x].transform.position = new Vector2 (thumb.transform.position.x + (66*x), thumb.transform.position.y);
			images[x].transform.SetParent(panel.transform);
			//agregar
			images[x].GetComponent<CambiaImgClick>().ind=x;
			/*if (x>=14){
				float xx = panel.transform.position.x;
				float yy = panel.transform.position.y;
				Vector3 n = new Vector3 (1.0f+1, 1.0f);
				panel.transform.localScale = n;
				panel.transform.position = new Vector2(xx,yy);
			}*/
		}
		
		//EditorUtility.DisplayDialog(thumbs.Length.ToString(), "Seguro que deseas continuar?", "Si", "No");
	}
	
	// Update is called once per frame
	public void Avanza () {
		if (indice < thumbs.Length) {
			fondo.transform.position = new Vector2 (fondo.transform.position.x + 66, fondo.transform.position.y);
			indice++;
		} 
		if (indice == thumbs.Length) {
			indice--;
			gameObject.GetComponent<CapturarText> ().enabled = true;
		} else {
			Rect rec = new Rect (0, 0, thumbs [indice].width, thumbs [indice].height);
			Vector2 vec = new Vector2 (0.5f, 0.5f);
			objetoImagen.sprite = Sprite.Create (thumbs [indice], rec, vec);
		}
		if (i == 7) {
			barra.value += 0.25f;
			i = 0;
		}
		i++;
		
		
		
	}
	
	public void Retrocede() {
		if (indice > 0) {
			fondo.transform.position = new Vector2 (fondo.transform.position.x-66, fondo.transform.position.y);
			indice--;
		}
		if (i == 7) {
			barra.value -= 0.25f;
			i = 0;
		}
		i++;
		
		Rect rec = new Rect (0, 0, thumbs [indice].width, thumbs [indice].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		objetoImagen.sprite = Sprite.Create (thumbs [indice], rec, vec); 
		
	}
}
