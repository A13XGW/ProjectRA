﻿using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class CapturarText : MonoBehaviour {

	public InputField CampoTexto;
	public string ruta;

	public void ActivarTexto (){
		CampoTexto.gameObject.SetActive (true);
		CampoTexto.text = File.ReadAllText (ruta);
	}

	void Start(){
		//ruta = Application.dataPath;
		ruta = Application.persistentDataPath;
		ruta += "/Resources/Comentarios/";
		Directory.CreateDirectory (ruta);
		ruta += "Comentarios.txt";
		File.Create (ruta);
		//ruta = "./Assets/Resources/Comentarios/Comentario.txt"; 
	}

	public void guardar(){
		File.WriteAllText (ruta, CampoTexto.text);
		Application.LoadLevel ("Fase2");
	}
//	public void OnButtonDown(int level){
//		if (level ==0)
//			Application.LoadLevel ("Fase2");
//	}
} 