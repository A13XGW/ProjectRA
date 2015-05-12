using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class CapturarText : MonoBehaviour {
	public string TextoAGuardar = "Esribe tus comentarios";
	public GameObject panelTexto;
	public Text Texto;
	//private Rect miTextoCampo = new Rect(202,20,0,0);

	void OnGUI(){
		panelTexto.SetActive (true);
	//	TextoAGuardar = GUI.TextArea(miTextoCampo,TextoAGuardar);

	}
	void Update(){
		Texto.text = "Esribe tus comentarios";
		Texto.text = Keyframe;
	}
}

//Roundsleft.text = (Player.RoundsLeft).ToString("Rounds Left:"); 