﻿using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class CapturarText : MonoBehaviour {

	public InputField CampoTexto;
	public string ruta;
	public GameObject groupInputField;
	public int contadorFase=1;
	public void ActivarTexto (){
		groupInputField.SetActive (true);
		CampoTexto.text = File.ReadAllText (ruta);
	}

	void Start(){
		//ruta = Application.dataPath;
		ruta = Application.persistentDataPath;
		ruta += "/Resources/Comentarios/";
		Directory.CreateDirectory (ruta);
		ruta += "Comentarios.txt";
		if (File.Exists(ruta)) {
			File.ReadAllText (ruta);
		} else {
			File.Create (ruta);
		}
	}

	public void guardar(){
		File.WriteAllText (ruta, CampoTexto.text);
		contadorFase++;
		Application.LoadLevel ("Fase"+contadorFase);
	}
} 