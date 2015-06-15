using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class TExto : MonoBehaviour {
	public GameObject Texto;
	public GameObject flotante3;
	public GameObject flotante2;
	public GameObject flotante1;
	public GameObject flotante;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( flotante.GetComponent<Contador> ().contadorR == 5 && 
			flotante1.GetComponent<Contador> ().contadorR == 4 &&
			flotante2.GetComponent<Contador> ().contadorR == 4 && 
			flotante3.GetComponent<Contador> ().contadorR == 3) {
			Texto.SetActive(true);
		}
	}
}
