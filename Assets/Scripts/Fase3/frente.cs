using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class frente : MonoBehaviour {

	public Image objeto, imagen;

	// Use this for initialization
	void Start () {
		mostrar ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void mostrar(){

			objeto.gameObject.SetActive (true);
			objeto.sprite = Sprite.Create (imagen.sprite.texture, new Rect (0, 0, imagen.sprite.texture.width, imagen.sprite.texture.height), new Vector2 (0.5f, 0.5f));

	}

	public void ocultar(){
		objeto.gameObject.SetActive (false);
	}
}
