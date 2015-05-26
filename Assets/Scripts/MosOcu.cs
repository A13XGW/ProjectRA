using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MosOcu : MonoBehaviour {
	public Scrollbar barra;
	public void OcultarMostrar()	{
		if (barra.value == 0) {
			barra.value = 1;
		} else {
			barra.value = 0;
		}
	}
}
