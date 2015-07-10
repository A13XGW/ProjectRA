using UnityEngine;
using System.Collections;

public class MoverRotarObjeto3d : MonoBehaviour {
	public GameObject objeto, flecha, flechas;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void MoverDerecha () {
		objeto.transform.position = new Vector3 (objeto.transform.position.x + 0.1f , objeto.transform.position.y, objeto.transform.position.z);
	}

	public void MoverIzquierda() {
		objeto.transform.position = new Vector3 (objeto.transform.position.x - 0.1f , objeto.transform.position.y, objeto.transform.position.z);
	}

	public void Subir(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y + 0.1f, objeto.transform.position.z);
	}

	public void Bajar(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y - 0.1f, objeto.transform.position.z);
	}

	public void Acercar(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y, objeto.transform.position.z -0.1f);
	}
	
	public void Alejar(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y, objeto.transform.position.z + 0.1f);
	}

	public void Crecer(){
		objeto.transform.localScale = new Vector3 (objeto.transform.localScale.x+0.02f,objeto.transform.localScale.y+0.02f,objeto.transform.localScale.z+0.02f);
	}
	
	public void Disminuir(){
		objeto.transform.localScale = new Vector3 (objeto.transform.localScale.x-0.02f,objeto.transform.localScale.y-0.02f,objeto.transform.localScale.z-0.02f);
	}

	public void Rotar() {
		//flecha.SetActive (true);
		flechas.transform.position = new Vector3(objeto.transform.position.x,objeto.transform.position.y,objeto.transform.position.z-0.3f);
		//objeto.GetComponentInChildren<Transform> ().gameObject.SetActive (true);
		//Debug.Log ("Rotar");
		//objeto.transform.rotation = Quaternion.Euler (0, 45, 0);
		//objeto.transform.Rotate(Vector3.right * Time.deltaTime*75);
		//objeto.transform.Rotate(Vector3.forward * Time.deltaTime*-75);
	}

	public void borrar(){
		Destroy (objeto);
	}
	void Update() {

	}
}
