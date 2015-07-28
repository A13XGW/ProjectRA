using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BarraImgs : MonoBehaviour 
{
	public int Barra;
	public Button Animales, Objetos, Personas;
	public GameObject Anim, Obj, Per;
	public void OnButtondown()
	{
		switch (Barra) 
		{
		case 1:
			Objetos.interactable = true;
			Personas.interactable = true;
			Anim.SetActive(true);
			Obj.SetActive(false);
			Per.SetActive(false);
			Animales.interactable = false;
			break;

		case 2:
			Animales.interactable = true;
			Personas.interactable = true;
			Obj.SetActive(true);
			Anim.SetActive(false);
			Per.SetActive(false);
			Objetos.interactable = false;
			break;
		
		case 3:
			Objetos.interactable = true;
			Animales.interactable = true;
			Per.SetActive(true);
			Anim.SetActive(false);
			Obj.SetActive(false);
			Personas.interactable = false;
			break;
		
		default:
			break;
		}
	}
}
