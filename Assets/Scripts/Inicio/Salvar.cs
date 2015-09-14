using UnityEngine;
using System.Collections;

public class Salvar : MonoBehaviour {

	public GameObject objeto;
	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (gameObject);//Indica que el objeto asociado no sera destruido al cargar la siguiente escena
		objeto=gameObject;
	}

	void OnLevelWasLoaded(int level) {
		if(level>0) {
			Debug.Log ("Entra a cargar");
			GameObject clonObj = Instantiate(objeto);
			DontDestroyOnLoad (clonObj);

		}
	}
}
