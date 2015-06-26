using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Init : MonoBehaviour {
	public int usuario;
	public string[] nombre = new string[3];

	// Use this for initialization
	void Start () {
		nombre [0] = "uno";
		nombre [1] = "dos";
		nombre [2] = "tres";

		usuario = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
