using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ArregloInicio : MonoBehaviour {

	//Emmanuel
	public Image thumb;
	private Texture2D[] images;
	private GameObject[] tabla;
	public Image panel;


	// Use this for initialization
	void Start () {
		images = Resources.LoadAll<Texture2D>("Fase4");
		Rect rec = new Rect (0, 0, images [0].width, images [0].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		float filas = (images.Length / 5.0f);
		Debug.Log (filas);
		Image[] thumbs = new Image[images.Length];
		for (int x=1; x<=images.Length; x++) 
		{
				thumbs[x] = Instantiate(thumb);
				rec = new Rect (0, 0, images [x].width, images [x].height);
				thumbs[x].sprite = Sprite.Create (images [x], rec, vec);
				if(x>=5)
				{
					thumbs[x].transform.position = new Vector2 (thumb.transform.position.x + ((thumb.GetComponent<RectTransform>().sizeDelta.x + (thumb.GetComponent<RectTransform>().sizeDelta.x * 0.4831f))*x), thumb.transform.position.y);
				}else
				{
					thumbs[x].transform.position = new Vector2 (thumb.transform.position.x + ((thumb.GetComponent<RectTransform>().sizeDelta.x + (thumb.GetComponent<RectTransform>().sizeDelta.x * 0.4831f))*x), thumb.transform.position.y-(thumb.transform.position.y*.5f));
				}
				thumbs[x].transform.SetParent(panel.transform);
				thumbs[x].gameObject.GetComponent<RectTransform>().localScale = new Vector3(1.0f,1.0f,1.0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
