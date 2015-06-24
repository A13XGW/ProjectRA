using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Equipo : MonoBehaviour
{
	public InputField NEquipo;
	public int AEquipo;
	// Use this for initialization
	public void OnButtonDown(){
		PlayerPrefs.SetString ("NombreEquipo", NEquipo.text);
		PlayerPrefs.SetInt ("ImagenEquipo", AEquipo);
	}
}

