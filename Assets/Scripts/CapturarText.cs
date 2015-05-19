﻿using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class CapturarText : MonoBehaviour {

	public InputField CampoTexto;
	public string ruta;

	public void ActivarTexto (){
		CampoTexto.gameObject.SetActive (true);
	}

	void Start(){
		//ruta = Application.dataPath;
		//ruta += "/Resources/Comentarios/Comentario.txt";
		ruta = "./Assets/Resources/Comentarios/Comentario.txt"; 
		CampoTexto.text = File.ReadAllText (ruta);

	}

	public void guardar(){
		File.WriteAllText (ruta, CampoTexto.text);
		//Application.LoadLevel ("Fase2");
	}
	public void OnButtonDown(int level){
		if (level ==0)
			Application.LoadLevel ("Fase2");
		else 
			Application.LoadLevel ("iniciar");
	}
} 