using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class Integrantes : MonoBehaviour {
	int integrantes;
	public Text TotalIntegrantes;
	public InputField Integrante;
	public GameObject panelRegistro;
	/*
	void Start(){
		//integrantes = Convert.ToInt32 (TotalIntegrantes.text);
		Debug.Log(TotalIntegrantes.text);
		if(TotalIntegrantes.text != "" ){
			//integrantes = Int32.Parse(TotalIntegrantes.text);
			integrantes = Convert.ToInt32(TotalIntegrantes.text);
			PlayerPrefs.SetInt ("IntegrantesTotal", integrantes);
			Debug.Log(integrantes);
		}
	}
	*/
	public void OnButtonDown(){
		integrantes = Convert.ToInt32(TotalIntegrantes.text);
		Debug.Log ("entra integrantes" +  Integrante.text);

		PlayerPrefs.SetString ("Integrante1", Integrante.text);
		for (int i = 1; i < integrantes; i++) {
			Debug.Log("entra ciclo integrantes");
			Debug.Log (panelRegistro.GetComponent<SiguienteReg>().tmp[i].GetComponent<InputField>().text);
			PlayerPrefs.SetString ("Integrante"+(i+1), panelRegistro.GetComponent<SiguienteReg>().tmp[i].GetComponent<InputField>().text);
		}
	}

	public void CambiaIntegrantes() {
		//integrantes = Convert.ToInt32 (TotalIntegrantes.text);

		if(TotalIntegrantes.text != "" ){
			//integrantes = Int32.Parse(TotalIntegrantes.text);
			integrantes = Convert.ToInt32(TotalIntegrantes.text);
			PlayerPrefs.SetInt ("IntegrantesTotal", integrantes);

		}
	}
}
