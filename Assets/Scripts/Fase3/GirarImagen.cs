using UnityEngine;
using System.Collections;


public class GirarImagen : MonoBehaviour 
{
	public float Velocidadx = 0.005F;
	public float Velocidady = 0.005F;
	void Start()
	{


	}
	void Update () 
	{
		girar ();
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


		transform.localScale += new Vector3(Velocidadx, Velocidady , 0);
	}
}
