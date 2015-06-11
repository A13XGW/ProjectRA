using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CargarImagenes : MonoBehaviour {
	public Image thumb;
	private Texture2D[] thumbs;
	public Image panel;
	public GameObject panelS;
	public RectTransform rectPanel;
	// Use this for initialization
	void Start () {
		thumbs = Resources.LoadAll<Texture2D>("Fase4");
		
		Rect rec = new Rect (0, 0, thumbs [0].width, thumbs [0].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		thumb.sprite = Sprite.Create (thumbs [0], rec, vec);
		Image[] images = new Image[thumbs.Length];

		for (int x=1; x<thumbs.Length; x++) {
			rectPanel = panelS.GetComponent<RectTransform> ();
			rectPanel.sizeDelta = new Vector2 (rectPanel.sizeDelta.x+(thumb.GetComponent<RectTransform>().sizeDelta.x + (thumb.GetComponent<RectTransform>().sizeDelta.x * 0.20f)), rectPanel.sizeDelta.y);
			images[x] = Instantiate(thumb);
			rec = new Rect (0, 0, thumbs [x].width, thumbs [x].height);
			images[x].sprite = Sprite.Create (thumbs [x], rec, vec);
			images[x].transform.position = new Vector2 (thumb.transform.position.x + ((thumb.GetComponent<RectTransform>().sizeDelta.x + (thumb.GetComponent<RectTransform>().sizeDelta.x * 0.20f))*x), thumb.transform.position.y);
			images[x].transform.SetParent(panel.transform);
			images[x].gameObject.GetComponent<RectTransform>().localScale = new Vector3(1.0f,1.0f,1.0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
