using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cambiarNombre : MonoBehaviour {
	private Bandera ban;
	public Text boton;
	public GameObject panelGirar;

	void Start()
	{
		ban = panelGirar.GetComponent<Bandera> ();
	}
	// Update is called once per frame
	void Update () {
		if (ban.bandera == 0) {
			boton.text = "Derecha";
		} else {
			boton.text = "Izquierda";
		}
	}
}
