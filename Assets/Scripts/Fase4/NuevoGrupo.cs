﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class NuevoGrupo : MonoBehaviour {
	public GameObject grupo;
	public Transform canvas;
	private int contador=1;
	private string tagGrupo;
	public void OnButtonDown(){
		grupo.SetActive (true);
		GameObject tmp = Instantiate (grupo);
		tmp.transform.SetParent (canvas);
		tmp.transform.position = new Vector2(Screen.width/2,Screen.height/2);
		tagGrupo = "grupo" + contador;
		//Debug.Log (tagGrupo);
		tmp.gameObject.tag = tagGrupo;
		contador++;
		grupo.SetActive (false);
	}
}