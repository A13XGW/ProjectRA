using UnityEngine;
using System.Collections;

using System.IO;

using UnityEngine.UI;

public class GuardarImg : MonoBehaviour {
	public WWW www;
	public Image screen;
	int xb, yb;
	public Texture2D textu;
	public Texture2D textura;
	Texture2D tmp;
	public GameObject boton;
	private int bandera;
	public GameObject AlertaGuardando;

	//public Image imagen;

	string url;
	public Image lienzo;
	public GameObject kanvas;
	string rt;
	public int capturas;
	public string ruta;
	public string rutaG;
	
	// Use this for initialization
	void Start () {
		bandera = 1;
		capturas = 1;
		ruta = Application.persistentDataPath;
		ruta += "/Resources/Fase2/Capturas/";
		if (!Directory.Exists (ruta)) {
			Directory.CreateDirectory (ruta);
		}
		if (!Directory.Exists (Application.persistentDataPath + "/Resources/Fase2/Individual")) {
			Directory.CreateDirectory (Application.persistentDataPath + "/Resources/Fase2/Individual");
		}
		if (!Directory.Exists (Application.persistentDataPath + "/Resources/Fase2/Grupal")) {
			Directory.CreateDirectory (Application.persistentDataPath + "/Resources/Fase2/Grupal");
		}

		rutaG = "/Resources/Fase2/Individual/";

//		if (bandera.bandera == 1) 
//		{
//			rutaG = "/Resources/Fase2/Individual";
//			capturas = 0;
//		}
//		if(bandera.bandera == 0)
//		{
//			rutaG = "/Resources/Fase2/Grupal";
//			capturas = 0;
//		}
		//Directory.CreateDirectory (ruta);
		//Directory.CreateDirectory (Application.persistentDataPath + "/Resources/Fase2/Individual");
		//Directory.CreateDirectory (Application.persistentDataPath + "/Resources/Fase2/Grupal");
		//rt = ruta + "scr"+capturas+".png";
		xb = 0;
		yb = 0;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.F12)) {//Condicional - Listener de la tecla F12 para una accion especifica
			if(bandera == 0)
			{
				bandera = 1;
				rutaG = "/Resources/Fase2/Individual/";
				capturas = 1;
			}else{
				bandera = 0;
				rutaG = "/Resources/Fase2/Grupal/";
				capturas = 1;
			}
		}
	}

	IEnumerator Espera(float waitTime) {
		Debug.Log(Time.time);
		yield return new WaitForSeconds(waitTime);
		Debug.Log(Time.time);
		url = "file://" + rt;
		www = new WWW(url);
		yield return www;
		textu = www.texture;
		Rect r;
		Vector2 v = new Vector2 (0.5f,0.5f);
		r = new Rect (0,0,textu.width,textu.height);
		screen.sprite = Sprite.Create (textu,r,v);
		guardar ();
	}

	public void guardar () {

		
		//StartCoroutine (Espera(5.05f));
		//StartCoroutine(Imagenes());
		
		//---Asignar el fondo a la textura a guardar------------------------------
		//int ancho = Screen.width;
		//int alto = Screen.height;
		int ancho = (int)kanvas.GetComponent<RectTransform>().sizeDelta.x;
		int alto = (int)kanvas.GetComponent<RectTransform>().sizeDelta.y;
		Debug.Log (ancho+"x, " + alto + "y");
		textura = new Texture2D (ancho, alto);
		//textura = new Texture2D (600, 278);
		screen.gameObject.SetActive (true);
		
		/*for (int x=0; x<ancho; x++) {
			for (int y=0;y<alto;y++) {
				//textura.SetPixel(x, y, new Color(255, 0, 255));
//				textura.SetPixel(x, y, Color.white);
				textura.SetPixel(x, y, lienzo.sprite.texture.GetPixel(x,y));
			}
		}
		textura.Apply();*/
		
		//-----
		
		
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
		/*Image[] imagenes = lienzo.GetComponentsInChildren<Image> ();
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
		}*/
		//------------------------------------------------------------------------
		yb = 0;
		for (int y = 201; y <= 479; y++) 
		{
			//yb=0;
			for(int x = 400; x <= 1000; x++)
			{
				textura.SetPixel(xb,yb, screen.sprite.texture.GetPixel(x,y));
				xb++;
			}
			xb=0;
			yb++;
		}
		textura.Apply();
		
		
		//---Guardar imagen-------------------------------------------------------
		byte[] textureBuffer = textura.EncodeToPNG();
		
		//BinaryWriter binary = new BinaryWriter(File.Open (Application.persistentDataPath + "/Resources/Fase2/Individual/Imagen"+capturas+".png",FileMode.Create));
		BinaryWriter binary = new BinaryWriter(File.Open (Application.persistentDataPath + rutaG + "Imagen" + capturas + ".jpg",FileMode.Create));

		binary.Write(textureBuffer);
		Debug.Log ("Guardado");
		capturas++;
		screen.gameObject.SetActive (false);
		boton.GetComponent<Button> ().interactable = true;

		//------------------------------------------------------------------------
	}
	public void gd()
	{
		boton.GetComponent<Button> ().interactable = false;
		AlertaGuardando.SetActive (true);
		rt = ruta + "scr0"+capturas+".png";
		Debug.Log("antes");
		Application.CaptureScreenshot (rt);
		Debug.Log(Time.time);
		//StartCoroutine(Espera(5.0f));
		StartCoroutine (Espera (2.0f));
		Debug.Log(Time.time);
	}


}
