using UnityEngine;
using System.Collections;

public class CargarEscena : MonoBehaviour {	
	public int fase;

	public void OnButtonDown(){
		Application.LoadLevel ("Fase"+fase);
	}
}
