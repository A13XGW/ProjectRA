using UnityEngine;
using System.Collections;

using System.IO;

using UnityEngine.UI;

public class GuardarImg : MonoBehaviour {
	public Texture2D textura;
	public Image imagen;
	public Image lienzo;

	// Use this for initialization
	void Start () {

	}

	void OnGUI () {
		textura = new Texture2D (20, 20);
		for (int x=0; x<20; x++) {
			for (int y=0;y<20;y++) {
				textura.SetPixel(x, y, new Color(255, 0, 0));
			}
		}
		textura.Apply();
		GUIStyle generic_style = new GUIStyle();
		GUI.skin.box = generic_style;
		GUI.Box (new Rect (50, 50, 20, 20), textura);

		Rect rec = new Rect (0, 0, textura.width, textura.height);
		Vector2 vec = new Vector2 (0.5f, 0.5f);
		lienzo.sprite = Sprite.Create (textura, rec, vec);

		byte[] textureBuffer = textura.EncodeToPNG();
		BinaryWriter binary = new BinaryWriter(File.Open (Application.dataPath + "/myTextureName.png",FileMode.Create));
		binary.Write(textureBuffer);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
