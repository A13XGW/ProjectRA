using UnityEngine;
using System.Collections;

using UnityEngine.UI;
using System.IO;
//using System.Diagnostics;

public class Carga : MonoBehaviour {

	public Texture2D[] individual, grupo;
	public Image pindividual, pgrupo, prefab;
	public Image[] aindividual, agrupo;
	public int[] ifindividual, ioindividual, ifgrupo, iogrupo;

	// Use this for initialization
	IEnumerator Start () {
		individual = Resources.LoadAll<Texture2D> ("Fase6/Individual");
		grupo = Resources.LoadAll<Texture2D> ("Fase6/Grupo");

		//---Carga externa--------
		//string url = "http://images.earthcam.com/ec_metros/ourcams/fridays.jpg";
		string url = "file://C:/Users/alexa_000/Desktop/Individual/(207).jpg";
		//string url = "file://C:/Users/alexa_000/Desktop/Individual/";
		WWW www = new WWW(url);
		yield return www;
		individual [0] = www.texture;
		//Renderer renderer = GetComponent<Renderer>();
		//renderer.material.mainTexture = www.texture;
		//------------------------

		ifindividual = new int[individual.Length];
		ioindividual = new int[individual.Length];
		ifgrupo = new int[grupo.Length];
		iogrupo = new int[grupo.Length];

		Rect r;
		Vector2 v = new Vector2 (0.5f,0.5f);

		aindividual = new Image[individual.Length];
		for (int x=0; x<individual.Length; x++) {
			aindividual[x] = Instantiate(prefab);
			r = new Rect (0,0,individual[x].width,individual[x].height);
			aindividual[x].GetComponentsInChildren<Image>()[1].sprite = Sprite.Create(individual[x],r,v);
			aindividual[x].transform.SetParent(pindividual.transform);

			ifindividual[x] = -1;
			ioindividual[x] = -1;
		}

		agrupo = new Image[grupo.Length];
		for (int x=0; x<grupo.Length; x++) {
			agrupo[x] = Instantiate(prefab);
			r = new Rect (0,0,grupo[x].width,grupo[x].height);
			agrupo[x].GetComponentsInChildren<Image>()[1].sprite = Sprite.Create(grupo[x],r,v);
			agrupo[x].transform.SetParent(pgrupo.transform);

			ifgrupo[x] = -1;
			iogrupo[x] = -1;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void cambio(){
		for (int x=0; x<individual.Length; x++) {
			ifindividual[x] = (int)aindividual [x].GetComponentsInChildren<Slider> ()[0].value;
			ioindividual[x] = (int)aindividual [x].GetComponentsInChildren<Slider> ()[1].value;
		}
		for (int x=0; x<grupo.Length; x++) {
			ifgrupo[x] = (int)agrupo [x].GetComponentsInChildren<Slider> ()[0].value;
			iogrupo[x] = (int)agrupo [x].GetComponentsInChildren<Slider> ()[1].value;
		}
	}

	public void continuar(){
		int encontro = 0;

		for (int x=0; x<individual.Length; x++) {
			if (ifindividual[x] < 1 || ioindividual[x] < 1 || ifgrupo[x] < 1 || iogrupo[x] < 1){ encontro = 1; break; }
		}

		if (encontro == 0) Debug.Log ("Finalizado");
		else Debug.Log ("Aun no has terminado de evaluar");
	}

	public int mostrar=0;
	public void teclado(){
		if (mostrar == 0) {
			System.Diagnostics.Process.Start ("osk");
			mostrar = 1;
		} else {
			var myProcess = new System.Diagnostics.Process();
			myProcess.StartInfo.FileName = "tskill";
			myProcess.StartInfo.Arguments = "osk";
			myProcess.Start();
			mostrar = 0;
		}
	}

	public Image Modal;
	public void cerrarmodal(){
		Modal.gameObject.SetActive (false);
	}
}