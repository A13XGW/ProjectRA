using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class SiguienteReg : MonoBehaviour {
	public GameObject panelRegEquipo;
	public GameObject PanelRegIntegrantes;
	public GameObject AlertNada;
	public GameObject AlertMenor;
	public GameObject integrante;
	public GameObject Textintegrante;
	public GameObject PanelIntegrantes;
	public GameObject AvaIntegrantes;
	public Scrollbar barra;
	public GameObject[] tmp;
	int integrantes;
	public Text integr;
	public void OnButtonDown(){
		integrantes = Convert.ToInt32 (integr.text);
		if (integr.text != null) {
			if (integrantes > 1) {
				PanelRegIntegrantes.SetActive(true);
				GameObject[] temp;
				GameObject[] Ava;
				//Debug.Log (integrantes);
				tmp = new GameObject[integrantes];
				temp = new GameObject[integrantes];
				Ava = new GameObject[integrantes];
				//Debug.Log (tmp.Length);
				for (int i = 1; i < integrantes; i++) {
					tmp[i] = Instantiate(integrante);
					tmp[i].transform.SetParent(PanelIntegrantes.transform);
					tmp[i].transform.localScale = new Vector3 (1f,1f,1f);
					tmp[i].transform.position = new Vector2(integrante.transform.position.x, integrante.transform.position.y);
					tmp[i].transform.position = new Vector2(integrante.transform.position.x, integrante.transform.position.y - 20f*i);
					
					temp[i] = Instantiate(Textintegrante);
					temp[i].transform.SetParent(PanelIntegrantes.transform);
					temp[i].transform.localScale = new Vector3 (1f,1f,1f);
					temp[i].transform.position = new Vector2(Textintegrante.transform.position.x, Textintegrante.transform.position.y);
					temp[i].transform.position = new Vector2(Textintegrante.transform.position.x, Textintegrante.transform.position.y - 20f*i);
					temp[i].GetComponent<Text>().text = "Integrante " + (i+1) + ":"; 

					Ava[i]= Instantiate(AvaIntegrantes);
					Ava[i].transform.SetParent(PanelIntegrantes.transform);
					Ava[i].transform.localScale = new Vector3 (1f,1f,1f);
					Ava[i].transform.position = new Vector2(AvaIntegrantes.transform.position.x, AvaIntegrantes.transform.position.y);
					Ava[i].transform.position = new Vector2(AvaIntegrantes.transform.position.x, AvaIntegrantes.transform.position.y - 20f*i);


					if( i > 5){
						Debug.Log(i);
						PanelIntegrantes.GetComponent<RectTransform>().sizeDelta = new Vector2 (PanelIntegrantes.GetComponent<RectTransform>().sizeDelta.x,PanelIntegrantes.GetComponent<RectTransform>().sizeDelta.y + 30f);
					}
				}
				panelRegEquipo.SetActive (false);
				//Debug.Log (integrantes);
			} else {
				AlertMenor.SetActive(true);
			}
		} else {
			AlertNada.SetActive(true);
		}
	}
}
