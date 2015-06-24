using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class Integrantes : MonoBehaviour {
	int integrantes;
	public InputField TotalIntegrantes;
	public InputField Integrante;
	void Start(){
		integrantes = Convert.ToInt32 (TotalIntegrantes.text);
	}
	public void OnButtonDown(){
		PlayerPrefs.SetString ("Integrante1", Integrante.text);
		for (int i = 1; i < integrantes; i++) {
			PlayerPrefs.SetString ("Integrante"+(i+1), GetComponent<SiguienteReg>().tmp[i].GetComponent<InputField>().text);
		}
	}
}
