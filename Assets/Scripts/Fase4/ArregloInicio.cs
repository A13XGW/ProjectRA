using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ArregloInicio : MonoBehaviour {

	//Emmanuel
	public Image thumb;
	private Texture2D[] images;
	private GameObject[] tabla;
	public Image panel;
	public GameObject panelS;
	public RectTransform rectPanel;


	// Use this for initialization
	void Start () {
		images = Resources.LoadAll<Texture2D>("Fase4");
		Rect rec = new Rect (0, 0, images [0].width, images [0].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);

		Image[] thumbs = new Image[images.Length];
		for (int x=1; x<images.Length; x++) 
		{
			rectPanel = panelS.GetComponent<RectTransform> ();
			if(x<5)
			{
				rectPanel.sizeDelta = new Vector2 (rectPanel.sizeDelta.x+(thumb.GetComponent<RectTransform>().sizeDelta.x + (thumb.GetComponent<RectTransform>().sizeDelta.x * 0.20f)), rectPanel.sizeDelta.y);
			}
			if(x==6)
			{
				rectPanel.sizeDelta = new Vector2 (rectPanel.sizeDelta.x, rectPanel.sizeDelta.y+(thumb.GetComponent<RectTransform>().sizeDelta.y + (thumb.GetComponent<RectTransform>().sizeDelta.y * 0.40f)));
			}
			thumbs[x] = Instantiate(thumb);
			if(x==1){thumb.sprite=Sprite.Create(images[0],rec,vec);}
			rec = new Rect (0, 0, images [x].width, images [x].height);
			thumbs[x].sprite = Sprite.Create (images [x], rec, vec);
			if(x<5)
			{
				thumbs[x].transform.position = new Vector2 (thumb.transform.position.x + ((thumb.GetComponent<RectTransform>().sizeDelta.x + (thumb.GetComponent<RectTransform>().sizeDelta.x * 0.20f))*x), thumb.transform.position.y);
			}else
			{
				thumbs[x].transform.position = new Vector2 (thumb.transform.position.x + ((thumb.GetComponent<RectTransform>().sizeDelta.x + (thumb.GetComponent<RectTransform>().sizeDelta.x * 0.20f))*(x-5)), thumb.transform.position.y-(thumb.transform.position.y* 0.5f));
			}
			thumbs[x].transform.SetParent(panel.transform);
			thumbs[x].gameObject.GetComponent<RectTransform>().localScale = new Vector3(1.0f,1.0f,1.0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
