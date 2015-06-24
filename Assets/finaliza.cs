using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class finaliza : MonoBehaviour {
	public GameObject Grupo;
	public Text IntegranteT;
	int integrantes;
	public GameObject[] tmp;
	void Start(){
		integrantes = Convert.ToInt32 (IntegranteT.text);
		tmp = new GameObject[integrantes];
	}

	public void OnButtonDown(){
		DontDestroyOnLoad(Grupo);
		GameObject temporal;
		for (int i = 0; i < integrantes; i++) {
			temporal = GameObject.FindGameObjectWithTag("AvatarI");
			if(temporal != tmp[i]){
				tmp[i] = temporal;
			}

		}
		//DontDestroyOnLoad(GameObject.FindGameObjectsWithTag("AvatarI"));
		Application.LoadLevel ("Fase1");
	}
}
