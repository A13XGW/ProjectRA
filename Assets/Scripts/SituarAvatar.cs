using UnityEngine;
using System.Collections;

public class SituarAvatar : MonoBehaviour {
	 GameObject AvatarEquipo;
	public GameObject canvas;
	// Use this for initialization
	void Start () {
		AvatarEquipo = GameObject.FindGameObjectWithTag("AvatarI");
		AvatarEquipo.transform.SetParent (canvas.transform);
		AvatarEquipo.transform.position = new Vector2 (50,150);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
