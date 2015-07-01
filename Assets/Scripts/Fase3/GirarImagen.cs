using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class GirarImagen : MonoBehaviour 
{
	public float Velocidadx = 0.0025F;
	public float Velocidady = 0.0025F;

	public Transform padre;

	public bool girarObj=true;

	void Start()
	{
		padre = gameObject.transform;

	}
	void Update () 
	{
		//if (transform.parent != padre){
			girar ();
		//}
	}
	public void girar()
	{
	//	transform.Rotate (Vector3.forward * Time.deltaTime * Velocidad);
		transform.localScale += new Vector3(Velocidadx, Velocidady , 0);
		if (gameObject.transform.localScale.x >= 1.2) {
			transform.localScale = new Vector3(1, 1, 1);

		}
	}


	
	public void acomodar(){
	//	transform.rotation =  Quaternion.Euler(0, 0, 0);
		transform.localScale += new Vector3(0, 0 , 0);
	}
}
