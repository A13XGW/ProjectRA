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
	public GameObject PanelIntegrantes;
	int integrantes;
	public Text integr;
	public void OnButtonDown(){
		integrantes = Convert.ToInt32 (integr.text);
		if (integr.text != null) {
			if (integrantes > 1) {
				panelRegEquipo.SetActive (false);
				PanelRegIntegrantes.SetActive (true);
				Debug.Log (integrantes);
			} else {
				AlertMenor.SetActive(true);
			}
		} else {
			AlertNada.SetActive(true);
		}
		GameObject[] tmp;
		tmp = new GameObject[integrantes];
		for (int i = 2; i <= integrantes; i++) {
			tmp[i] = Instantiate(integrante);
			tmp[i].transform.SetParent(PanelIntegrantes.transform);
			tmp[i].transform.localScale = new Vector3 (1f,1f,1f);
			tmp[i].transform.position = new Vector2(integrante.transform.position.x - integrante.transform.position.x,integrante.transform.position.y);
		}
	}
}
