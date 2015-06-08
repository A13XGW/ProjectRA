using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ArregloInicio : MonoBehaviour {

	//Emmanuel
	public Image thumb;
	private Texture2D[] images;
	private GameObject[] tabla;


	// Use this for initialization
	void Start () {
		images = Resources.LoadAll<Texture2D>("Fase4");
		Rect rec = new Rect (0, 0, images [0].width, images [0].height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		float filas = (images.Length / 5.0f);
		Debug.Log (filas);
		Image[] thumbs = new Image[images.Length];
		for (int y=1; y <= filas; y++) 
		{
			for(int x=1; x <=5; x++)
			{

			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
