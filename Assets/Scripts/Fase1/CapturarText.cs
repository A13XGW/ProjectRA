﻿using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class CapturarText : MonoBehaviour {

	public InputField CampoTexto;
	public string ruta;
	public GameObject groupInputField;
	public InputField tmp;
	public int contadorFase;
	public GameObject FaseCompletada;

	void Start(){
		//ruta = Application.dataPath;
		ruta = Application.persistentDataPath;
		ruta += "/Resources/Comentarios/";
		Directory.CreateDirectory (ruta);
		ruta += "Comentarios.txt";
		if (File.Exists(ruta)) {
			if(contadorFase == 1)
				tmp.text = "Comentarios Fase" + contadorFase +"\n"+ File.ReadAllText (ruta);

			if(contadorFase > 1)
				tmp.text = File.ReadAllText (ruta) +"\n" + "Comentarios Fase" + contadorFase + "\n";

		} else {
			File.Create (ruta);
		}
	}
	public void ActivarTexto (){
		groupInputField.SetActive (true);
		TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default,false,true,true,true);
		System.Diagnostics.Process.Start("osk.exe");
	}
	public void guardar(){
		tmp.text += CampoTexto.text;
		File.WriteAllText (ruta, tmp.text, System.Text.Encoding.UTF8);
		FaseCompletada.SetActive (true);
	}
} 