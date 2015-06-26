using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Modal : MonoBehaviour {
	public Image img;

	// Use this for initialization
	void Start () {
		img = gameObject.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Image Modall;
	public void modal(){
		Modall.gameObject.SetActive (true);
		Rect r;
		Vector2 v = new Vector2 (0.5f,0.5f);
		r = new Rect (0,0,img.sprite.texture.width,img.sprite.texture.height);
		Modall.GetComponentsInChildren<Image> ()[1].sprite = Sprite.Create(img.sprite.texture,r,v);
	}
}