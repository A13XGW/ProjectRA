using UnityEngine;
using System.Collections;

public class MoverRotarObjeto3d : MonoBehaviour {
	public GameObject objeto;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void MoverDerecha () {
		objeto.transform.position = new Vector3 (objeto.transform.position.x + 1 , objeto.transform.position.y, objeto.transform.position.z);
	}

	public void MoverIzquierda() {
		objeto.transform.position = new Vector3 (objeto.transform.position.x - 1 , objeto.transform.position.y, objeto.transform.position.z);
	}

	public void Subir(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y + 1, objeto.transform.position.z);
	}

	public void Bajar(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y - 1, objeto.transform.position.z);
	}

	public void Acercar(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y, objeto.transform.position.z -1);
	}
	
	public void Alejar(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y, objeto.transform.position.z + 1);
	}

	public void Rotar() {
		Debug.Log ("Rotar");
		objeto.transform.Rotate(Vector3.right * Time.deltaTime*75);
		objeto.transform.Rotate(Vector3.forward * Time.deltaTime*-75);
	}

	public void borrar(){
		Destroy (objeto);
	}
	void Update() {

	}
}
