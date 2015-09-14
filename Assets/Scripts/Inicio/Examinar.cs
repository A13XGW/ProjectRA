using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Examinar : MonoBehaviour {
//Selecionar imagend e grupo
	public Image thumb;
	Texture2D[] thumbs;
	public GameObject ImgGrupo;
	public GameObject panel;
	public Image[] images;
	void Start(){
		thumbs = Resources.LoadAll<Texture2D> ("Flags");
		Rect rec = new Rect (0, 0, thumbs [0].width, thumbs [0].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		images = new Image[thumbs.Length];
		for (int x=1; x<thumbs.Length; x++) {
			images [x] = Instantiate (thumb);
			rec = new Rect (0, 0, thumbs [x].width, thumbs [x].height);
			images [x].sprite = Sprite.Create (thumbs [x], rec, vec);
			//images [x].transform.position = new Vector2 (thumb.transform.position.x + ((thumb.GetComponent<RectTransform> ().sizeDelta.x + (thumb.GetComponent<RectTransform> ().sizeDelta.x * 0.20f)) * x), thumb.transform.position.y);
			images [x].transform.SetParent (panel.transform);
			images [x].gameObject.GetComponent<RectTransform> ().localScale = new Vector3 (1.0f, 1.0f, 1.0f);
			images[x].GetComponent<ImgAvatarGrupo>().ind=x;
		}
		Rect recto=new Rect (0, 0, 512, 512);
		thumb.sprite = Sprite.Create (thumbs [0], recto, vec);
	}
	public void OnButtonDown(){
		ImgGrupo.SetActive(true);


	}
}
