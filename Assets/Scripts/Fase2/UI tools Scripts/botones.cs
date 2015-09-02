using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class botones : MonoBehaviour
{
	public GameObject panelCorteTipos;
	public int opcion, tipo, sentido;
	public Button[] boton;
	// Use this for initialization
	void Start () {
		opcion = 0;
		sentido = 0;
		tipo = 0;
		boton = GetComponentsInChildren<Button>();
	}
	
	// Update is called once per frame
	public void OpcionActual (int opt, int tp, int sen) {
		opcion = opt;
		tipo = tp;
		sentido = sen;
		//1 es frente, 2 es cortar y 3 es rotar
	}

	public void OnCorteDown(){
		panelCorteTipos.SetActive (true);
	}
}

