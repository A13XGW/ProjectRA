using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class CapturarText : MonoBehaviour {
	public string TextoAGuardar;
	public InputField CampoTexto;
	public void ActivateInputField (){
		//CampoTexto.transform.
	}
	public void guardar(){
		TextoAGuardar = CampoTexto.text;

	}
}

//Roundsleft.text = (Player.RoundsLeft).ToString("Rounds Left:"); 