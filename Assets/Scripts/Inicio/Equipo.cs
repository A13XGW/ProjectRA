using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Equipo : MonoBehaviour
{
	public InputField NEquipo;
	public int AEquipo;
	// Use this for initialization
	public void OnButtonDown(){
		PlayerPrefs.SetString ("NombreEquipo", NEquipo.text);//define la variable global NombreEqipo
		PlayerPrefs.SetInt ("ImagenEquipo", AEquipo);//define la variable global ImagenEquipo
	//	Debug.Log("nombreEq");
	}
}

