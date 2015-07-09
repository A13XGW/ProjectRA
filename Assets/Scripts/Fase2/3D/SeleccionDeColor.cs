using UnityEngine;
using System.Collections;

public class SeleccionDeColor : MonoBehaviour {

public GameObject objeto;

	public void Azul(){
		objeto.GetComponent<Renderer> ().material.color = Color.blue;
	}
	public void Verde(){
		objeto.GetComponent<Renderer> ().material.color = Color.green;
	}
	public void Negro(){
		objeto.GetComponent<Renderer> ().material.color = Color.black;
	}
	public void Blanco(){
		objeto.GetComponent<Renderer> ().material.color = Color.white;
	}
	public void Rojo(){
		objeto.GetComponent<Renderer> ().material.color = Color.gray;
	}
//	public void GrisC(){
//		objeto.GetComponent<Renderer> ().material.color = new Color(200,200,200);
//	}
	public void GrisO(){
		objeto.GetComponent<Renderer> ().material.color = Color.grey;
	}
	public void Magenta(){
		objeto.GetComponent<Renderer> ().material.color = Color.magenta;
	}
	public void Cyan(){
		objeto.GetComponent<Renderer> ().material.color = Color.cyan;
	}
	public void Amarillo(){
		objeto.GetComponent<Renderer> ().material.color = Color.yellow;
	}
}
