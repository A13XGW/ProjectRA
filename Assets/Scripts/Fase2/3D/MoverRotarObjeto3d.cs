using UnityEngine;
using System.Collections;

public class MoverRotarObjeto3d : MonoBehaviour {
	public GameObject objeto, flechas, MenuRotar;
	public GameObject fx, fy, fz;
	int bandera;

	// Use this for initialization
	void Start () {
		bandera = 0;
		fx.GetComponent<RotarX> ().objeto = objeto;
		fy.GetComponent<RotarY> ().objeto = objeto;
		fz.GetComponent<RotarZ> ().objeto = objeto;
	}
	
	// Update is called once per frame
	public void MoverDerecha () {
		objeto.transform.position = new Vector3 (objeto.transform.position.x + 0.1f , objeto.transform.position.y, objeto.transform.position.z);
	}

	public void MoverIzquierda() {
		objeto.transform.position = new Vector3 (objeto.transform.position.x - 0.1f , objeto.transform.position.y, objeto.transform.position.z);
	}

	public void Subir(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y + 0.5f, objeto.transform.position.z);
	}

	public void Bajar(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y - 0.5f, objeto.transform.position.z);
	}

	public void Acercar(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y, objeto.transform.position.z -0.5f);
	}
	
	public void Alejar(){
		objeto.transform.position = new Vector3 (objeto.transform.position.x , objeto.transform.position.y, objeto.transform.position.z + 0.5f);
	}

	public void Crecer(){
		objeto.transform.localScale = new Vector3 (objeto.transform.localScale.x+0.02f,objeto.transform.localScale.y+0.02f,objeto.transform.localScale.z+0.02f);
	}
	
	public void Disminuir(){
		objeto.transform.localScale = new Vector3 (objeto.transform.localScale.x-0.02f,objeto.transform.localScale.y-0.02f,objeto.transform.localScale.z-0.02f);
	}

	public void Rotar() {
		if (bandera == 0) {
			bandera = 1;
			MenuRotar.SetActive (true);
			flechas.transform.position = new Vector3(-4.9f,-0.7f,-12.1f);

		} else {
			bandera = 0;
			MenuRotar.SetActive (false);
			flechas.transform.position = new Vector3(50f,50f,50f);

		}
	}

	public void Reset(){
		objeto.transform.rotation = Quaternion.identity;
	}
	public void borrar(){
		Destroy (objeto);
	}
	public void desactivarMenu(){
		MenuRotar.SetActive (false);
	}
	void Update() {

	}
}
