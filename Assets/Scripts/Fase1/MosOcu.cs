using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MosOcu : MonoBehaviour {
	public Scrollbar barra;
	public Text TextoBoton;
	public void OcultarMostrar()	{
		if (barra.value == 0) {
			barra.value = 1;
			TextoBoton.text = "Ocultar";
		} else {
			barra.value = 0;
			TextoBoton.text = "Mostrar";
		}
	}
}
