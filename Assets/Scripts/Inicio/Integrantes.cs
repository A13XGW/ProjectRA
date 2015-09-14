using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class Integrantes : MonoBehaviour {
	int integrantes;
	public Text TotalIntegrantes;
	public InputField Integrante;
	public GameObject panelRegistro;

//	public void CambiaIntegrantes() {//Convierte el valor de tipo cadena a entero si este es diferente de cadena vacia
//		if (TotalIntegrantes.text != "") {
//			//integrantes = Int32.Parse(TotalIntegrantes.text);
//			integrantes = Convert.ToInt32 (TotalIntegrantes.text);
//			PlayerPrefs.SetInt ("IntegrantesTotal", integrantes);
//		} else {
//
//		}
//	}

	public void OnButtonDown(){
		integrantes = Convert.ToInt32(TotalIntegrantes.text);//Convierte el valor de tipo cadena a un entero
		//Debug.Log ("entra integrantes" +  Integrante.text);
		PlayerPrefs.SetInt ("IntegrantesTotal", integrantes);//Define la variable global IntegratesTotal

		PlayerPrefs.SetString ("Integrante1", Integrante.text); //define la varaible global Integrane1
		for (int i = 1; i < integrantes; i++) {//Ciclo para definir el resto de integrantes
			Debug.Log("entra ciclo integrantes");
			Debug.Log (panelRegistro.GetComponent<SiguienteReg>().tmp[i].GetComponent<InputField>().text);
			PlayerPrefs.SetString ("Integrante"+(i+1), panelRegistro.GetComponent<SiguienteReg>().tmp[i].GetComponent<InputField>().text);
		}
	}


}
