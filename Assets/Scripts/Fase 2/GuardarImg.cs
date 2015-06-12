using UnityEngine;
using System.Collections;

using System.IO;

using UnityEngine.UI;

public class GuardarImg : MonoBehaviour {
	public Texture2D textura;
	Texture2D tmp;
	public Image imagen;

	public Image lienzo;
	public Canvas kanvas;

	// Use this for initialization
	void Start () {

	}

	void OnGUI(){
		int ancho = 20;
		int alto = 20;
		
		tmp = new Texture2D (ancho, alto);
		for (int x=0; x<ancho; x++) {
			for (int y=0;y<alto;y++) {
				tmp.SetPixel(x, y, new Color(255, 0, 255));
			}
		}
		tmp.Apply();
		GUIStyle generic_style = new GUIStyle();
		GUI.skin.box = generic_style;
		GUI.Box (new Rect (50, 50, 20, 20), tmp);
		//Rect rec = new Rect (0, 0, textura.width, textura.height);
		//Vector2 vec = new Vector2 (0.5f, 0.5f);
		//lienzo.sprite = Sprite.Create (textura, rec, vec);
	}

	public void guardar () {

		//---Asignar el fondo a la textura a guardar------------------------------
		int ancho = (int)kanvas.GetComponent<RectTransform>().sizeDelta.x;
		int alto = (int)kanvas.GetComponent<RectTransform>().sizeDelta.y;

		textura = new Texture2D (ancho, alto);
		for (int x=0; x<ancho; x++) {
			for (int y=0;y<alto;y++) {
				//textura.SetPixel(x, y, new Color(255, 0, 255));
				textura.SetPixel(x, y, lienzo.sprite.texture.GetPixel(0,0));
			}
		}
		textura.Apply();
		//------------------------------------------------------------------------

		//---Asignar el cuadro a la textura---------------------------------------
		int tmpx = 50;
		int tmpy = 50;

		for (int x=tmpx; x<tmpx+tmp.width; x++) {
			for (int y=textura.height-tmpy;y>textura.height-tmpy-tmp.height; y--){
				textura.SetPixel(x, y, tmp.GetPixel(x,y));
			}
		}
		textura.Apply();
		//------------------------------------------------------------------------

		//--- Asignar imagen a la textura-----------------------------------------
		/*int imgx = (int)imagen.transform.position.x;
		int imgy = (int)imagen.transform.position.y;
		int imgw = (int)imagen.GetComponent<RectTransform> ().sizeDelta.x;
		int imgh = (int)imagen.GetComponent<RectTransform> ().sizeDelta.y;

		for (int x=imgx; x<imgx+imgw; x++) {
			for (int y=textura.height-imgy;y>textura.height-imgy-imgh; y--){
				//textura.SetPixel(x, y, imagen.sprite.texture.GetPixel(x,y));
				//imagen.sprite.texture.Resize(imgw, imgh);
				textura.SetPixel(x, y, imagen.sprite.texture.GetPixel(x,y));
			}
		}
		textura.Apply();*/
		//------------------------------------------------------------------------

		//--- Tomar y asignar todas las imagenes----------------------------------
		Image[] imagenes = lienzo.GetComponentsInChildren<Image> ();
		for (int z=0; z<imagenes.Length; z++) {
			int imgsx = (int)imagenes[z].transform.position.x;
			int imgsy = (int)imagenes[z].transform.position.y;
			int imgsw = (int)imagenes[z].GetComponent<RectTransform> ().sizeDelta.x;
			int imgsh = (int)imagenes[z].GetComponent<RectTransform> ().sizeDelta.y;
			for (int x=imgsx; x<imgsx+imgsw; x++) {
				for (int y=textura.height-imgsy;y>textura.height-imgsy-imgsh; y--){
					//textura.SetPixel(x, y, imagen.sprite.texture.GetPixel(x,y));
					//imagen.sprite.texture.Resize(imgw, imgh);
					textura.SetPixel(x, y, imagenes[z].sprite.texture.GetPixel(x,y));
				}
			}
			textura.Apply();
		}
		//------------------------------------------------------------------------

		//---Guardar imagen-------------------------------------------------------
		byte[] textureBuffer = textura.EncodeToPNG();
		BinaryWriter binary = new BinaryWriter(File.Open (Application.dataPath + "/myTextureName.png",FileMode.Create));
		binary.Write(textureBuffer);

		Debug.Log ("Guardado");
		//------------------------------------------------------------------------
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
