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
	public Scrollbar barra;
	public GameObject[] tmp;
	int integrantes;
	public Text integr;

	public GameObject Equipo;
	public void OnButtonDown(){

		if (integr.text != "") {//valdia diferente de cadena vacia
			integrantes = Convert.ToInt32 (integr.text);//convierte valor de cadena a entero
			if (integrantes > 1 && integrantes < 7) {//valida que el numero este en el range definio
				PanelRegIntegrantes.SetActive(true);//vuelve visivle el cuadro de registro
				GameObject[] temp;
				//Debug.Log (integrantes);
				tmp = new GameObject[integrantes];
				temp = new GameObject[integrantes];
				//Debug.Log (tmp.Length);
				for (int i = 1; i < integrantes; i++) {//ciclo de instancia, nombramiento y psocionameinto de los cuadros de registro
					tmp[i] = Instantiate(integrante);
					tmp[i].transform.SetParent(PanelIntegrantes.transform);
					tmp[i].transform.localScale = new Vector3 (1f,1f,1f);
					tmp[i].transform.position = new Vector2(integrante.transform.position.x, integrante.transform.position.y);
					tmp[i].transform.position = new Vector2(integrante.transform.position.x, integrante.transform.position.y - 35f*i);
					
					temp[i] = Instantiate(Textintegrante);
					temp[i].transform.SetParent(PanelIntegrantes.transform);
					temp[i].transform.localScale = new Vector3 (1f,1f,1f);
					temp[i].transform.position = new Vector2(Textintegrante.transform.position.x, Textintegrante.transform.position.y);
					temp[i].transform.position = new Vector2(Textintegrante.transform.position.x, Textintegrante.transform.position.y - 35f*i);
					temp[i].GetComponent<Text>().text = "Integrante " + (i+1) + ":"; 

					Equipo.transform.SetParent (null);

					/*if( i > 5){
						Debug.Log(i);
						PanelIntegrantes.GetComponent<RectTransform>().sizeDelta = new Vector2 (PanelIntegrantes.GetComponent<RectTransform>().sizeDelta.x,PanelIntegrantes.GetComponent<RectTransform>().sizeDelta.y + 30f);
					}*/
				}
				panelRegEquipo.SetActive (false);
				//Debug.Log (integrantes);
			} else {
				AlertMenor.SetActive(true);//si el numero no esta en el rango llama a la ventan emergente
			}
		} else {
			if (AlertNada!=null)
				AlertNada.SetActive(true);//si el valor es vacio llama ventana emergente
		}
	}
}
