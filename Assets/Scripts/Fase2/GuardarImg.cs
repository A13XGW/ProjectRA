using UnityEngine;
using System.Collections;

using System.IO;

using UnityEngine.UI;

public class GuardarImg : MonoBehaviour {

	public Texture2D textura;
	Texture2D tmp;
	//public Image imagen;
	
	public Image lienzo;
	public GameObject kanvas;
	
	public int capturas;
	
	// Use this for initialization
	void Start () {
		capturas = 0;
		string ruta = Application.persistentDataPath;
		ruta += "/Resources/Fase2/New";
		Directory.CreateDirectory (ruta);
	}
	
		
	public void guardar () {
		
		//---Asignar el fondo a la textura a guardar------------------------------
		int ancho = (int)kanvas.GetComponent<RectTransform>().sizeDelta.x;
		int alto = (int)kanvas.GetComponent<RectTransform>().sizeDelta.y;
		Debug.Log (ancho+"x, " + alto + "y");
		textura = new Texture2D (ancho, alto);

		for (int x=0; x<ancho; x++) {
			for (int y=0;y<alto;y++) {
				//textura.SetPixel(x, y, new Color(255, 0, 255));
				textura.SetPixel(x, y, Color.white);

				//textura.SetPixel(x, y, lienzo.sprite.texture.GetPixel(0,0));
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
		Debug.Log (imagenes.Length);
		for (int z=1; z<imagenes.Length; z++) {
			int imgsx = (int)imagenes[z].transform.position.x;
			int imgsy = (int)imagenes[z].transform.position.y;
			int imgsw = (int)imagenes[z].GetComponent<RectTransform> ().sizeDelta.x;
			int imgsh = (int)imagenes[z].GetComponent<RectTransform> ().sizeDelta.y;

			imgsx -= 195;

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
		BinaryWriter binary = new BinaryWriter(File.Open (Application.persistentDataPath + "/Resources/Fase2/New/Imagen"+capturas.ToString()+".png",FileMode.Create));
		binary.Write(textureBuffer);
		
		Debug.Log ("Guardado");
		capturas++;
		//------------------------------------------------------------------------
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
