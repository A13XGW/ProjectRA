using UnityEngine;
using System.Collections;
using System;
public class Gestos : MonoBehaviour 
{
	float CoorInicial, CoorFinal, diferenciaX, diferenciaY, CoorInicial1, CoorFinal1, diferenciaX1, diferenciaY1;
	float tmpxF, tmpyF, tmpxI, tmpyI, tmpxF1, tmpyF1, tmpxI1, tmpyI1;
	int[] Sector = new int[8];
	public GameObject objeto;
	//public Text movimiento, XI, YI, XF, YF;
	// Update is called once per frame
	void Update () 
	{
		for(int i = 1; i <= 8; i++)
		{
			Sector[i]=0;
		}
		if (Input.touchSupported == true) 
		{//Validacion del soprte de touch
			if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
			{//Obtencion de la posicion del toque inicial
				tmpxI = Input.GetTouch (0).position.x;
				tmpyI = Input.GetTouch (0).position.y;
			}
			if (Input.GetTouch (0).phase == TouchPhase.Moved) 
			{//Si se mueve el dedo obtener la posicion actual
				tmpxF = Input.GetTouch (0).position.x;
				tmpyF = Input.GetTouch (0).position.y;
				
				if(tmpxI>tmpxF){//Revisa diferencias entre las posiciones inicales y finales para calcular la diferenica siempre en numeros positivos
					diferenciaX = tmpxI - tmpxF;
				}else{
					diferenciaX = tmpxF - tmpxI;
				}
				if(tmpyI>tmpyF){
					diferenciaY = tmpyI - tmpyF;
				}else{
					diferenciaY = tmpyF - tmpyI;
				}
				
				if (Input.GetTouch (0).phase == TouchPhase.Ended) 
				{//Validacion de la finalizacion del toque
					if (diferenciaX > diferenciaY) 
					{//revisa diferencia
						//Debug.Log ("X mayor");
						CoorInicial = tmpxI;
						CoorFinal = tmpxF;

						
						if (CoorInicial > CoorFinal  && diferenciaY < 50) 
						{
							//Debug.Log ("Movimiento a la izquierda");
						} 
						if (CoorInicial > CoorFinal  && diferenciaY > 50) 
						{
							if(tmpyF > tmpyI)
							{
							}
							if(tmpyF < tmpyI)
							{
							}
						}
						
						if (CoorInicial < CoorFinal  && diferenciaY < 50)
						{
							//Debug.Log ("Movimiento a la derecha");
						}
						if (CoorInicial < CoorFinal  && diferenciaY > 50) 
						{
							if(tmpyF > tmpyI)
							{
							}
							if(tmpyF < tmpyI)
							{
							}
						}
					} 
					else 
					{
						//Debug.Log ("Y mayor");
						CoorInicial = tmpyI;
						CoorFinal = tmpyF;

						
						if (CoorInicial > CoorFinal && diferenciaX < 50) 
						{
							//Debug.Log ("Movimiento hacia abajo");
						}
						if (CoorInicial > CoorFinal  && diferenciaX > 50) 
						{
							if(tmpxF > tmpxI)
							{
							}
							if(tmpxF < tmpxI)
							{
							}
						}
						
						if (CoorInicial < CoorFinal  && diferenciaX < 50)
						{
							//Debug.Log ("Movimiento hacia arriba");
						}
						if (CoorInicial > CoorFinal  && diferenciaX > 50) 
						{
							if(tmpxF > tmpxI)
							{
							}
							if(tmpxF < tmpxI)
							{
							}
						}
					}
				}
			}
			if(Input.multiTouchEnabled == true && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(1).phase == TouchPhase.Began)
			{//Validacion de multitouch y el movimineto de dos o más dedos
				tmpxI = Input.GetTouch (0).position.x;
				tmpyI = Input.GetTouch (0).position.y;

				tmpxI1 = Input.GetTouch (1).position.x;
				tmpyI1 = Input.GetTouch (1).position.y;
				if(Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(1).phase == TouchPhase.Moved)
				{
					tmpxF = Input.GetTouch (0).position.x;
					tmpyF = Input.GetTouch (0).position.y;

					tmpxF1 = Input.GetTouch (1).position.x;
					tmpyF1 = Input.GetTouch (1).position.y;

					if(tmpxI>tmpxF)
					{//Revisa diferencias entre las posiciones inicales y finales para calcular la diferenica siempre en numeros positivos
						diferenciaX = tmpxI - tmpxF;
						diferenciaX1 = tmpxI1 - tmpxF1;
					}else{
						diferenciaX = tmpxF - tmpxI;
						diferenciaX1 = tmpxF1 - tmpxI1;
					}

					if(tmpyI>tmpyF){
						diferenciaY = tmpyI - tmpyF;
						diferenciaY1 = tmpyI1 - tmpyF1;
					}else{
						diferenciaY = tmpyF - tmpyI;
						diferenciaY1 = tmpyF1 - tmpyI1;
					}
					//Empieza rescalamiento, tiene que se en tiempo real. Es decir en la fase de movimiento y no en la final

					if(diferenciaX > diferenciaY)
					{
						//Debug.Log("X mayor");
						CoorInicial = tmpxI;
						CoorFinal = tmpxF;

						
						if(CoorInicial > CoorFinal && diferenciaY < 50)
						{ 
							Sector[6] = 1;
							//Debug.Log("Movimiento a la izquierda");
						}
						if (CoorInicial > CoorFinal  && diferenciaY > 50) 
						{
							if(tmpyF > tmpyI)
							{
								Sector[2] = 1;
							}
							if(tmpyF < tmpyI)
							{
								Sector[3] = 1;
							}
						}
						if(CoorInicial < CoorFinal && diferenciaY < 50){
							Sector[8] = 1;
							//Debug.Log("Movimiento a la derecha");
						}
						if (CoorInicial < CoorFinal  && diferenciaY > 50) 
						{
							if(tmpyF > tmpyI)
							{
								Sector[1] = 1;
							}
							if(tmpyF < tmpyI)
							{
								Sector[4] = 1;
							}
						}
					}
					else
					{
						//Debug.Log("Y mayor");
						CoorInicial = tmpyI;
						CoorFinal = tmpyF;
						
						if(CoorInicial > CoorFinal)
						{
							if (diferenciaX > 50) 
							{
								if(tmpxF > tmpxI)
								{
									Sector[4] = 1;
								}
								if(tmpxF < tmpxI)
								{
									Sector[3] = 1;
								}
							}
							if(diferenciaX < 50){
							}
							Sector[7] = 1;
							//Debug.Log("Movimiento hacia abajo");
						}
						
						if(CoorInicial < CoorFinal ){
							
							if (diferenciaX > 50) 
							{
								if(tmpxF > tmpxI)
								{
									Sector[1] = 1;
								}
								if(tmpxF < tmpxI)
								{
									Sector[2] = 1;
								}
							}
							if(diferenciaX < 50)
							{
								Sector[5] = 1;
							}
						}
					}

					if(diferenciaX1 > diferenciaY1)
					{
						//Debug.Log("X mayor");
						CoorInicial1 = tmpxI1;
						CoorFinal1 = tmpxF1;

						
						if(CoorInicial1 > CoorFinal1 && diferenciaY1 < 50)
						{ 
							Sector[6] = 1;
							if(Sector[8]==1)
							{
								Debug.Log("Scale a lo ancho");
								objeto.transform.localScale = new Vector3(1+0.1f,1,1);
							}
							//Debug.Log("Movimiento a la izquierda");
						}
						if (CoorInicial1 > CoorFinal1  && diferenciaY1 > 50) 
						{
							if(tmpyF1 > tmpyI1)
							{
								Sector[2] = 1;
								if(Sector[4]==1)
								{
									Debug.Log("Scale total");
									objeto.transform.localScale = new Vector3(1+0.1f,1+0.1f,1+0.1f);
								}
							}
							if(tmpyF1 < tmpyI1)
							{
								Sector[3] = 1;
								if(Sector[1]==1)
								{
									Debug.Log("Scale total");
									objeto.transform.localScale = new Vector3(1+0.1f,1+0.1f,1+0.1f);
								}
							}
						}
						if(CoorInicial1 < CoorFinal1 && diferenciaY1 < 50){
							Sector[8] = 1;
							if(Sector[6]==1)
							{
								Debug.Log("Scale a lo ancho");
								objeto.transform.localScale = new Vector3(1+0.1f,1,1);
							}
							//Debug.Log("Movimiento a la derecha");
						}
						if (CoorInicial1 < CoorFinal1  && diferenciaY1 > 50) 
						{
							if(tmpyF1 > tmpyI1)
							{
								Sector[1] = 1;
								if(Sector[3]==1)
								{
									Debug.Log("Scale total");
									objeto.transform.localScale = new Vector3(1+0.1f,1+0.1f,1+0.1f);
								}
							}
							if(tmpyF1 < tmpyI1)
							{
								Sector[4] = 1;
								if(Sector[2]==1)
								{
									Debug.Log("Scale total");
									objeto.transform.localScale = new Vector3(1+0.1f,1+0.1f,1+0.1f);
								}
							}
						}
					}
					else
					{
						//Debug.Log("Y mayor");
						CoorInicial1 = tmpyI1;
						CoorFinal1 = tmpyF1;
						
						if(CoorInicial1 > CoorFinal1)
						{
							if (diferenciaX1 > 50) 
							{
								if(tmpxF1 > tmpxI1)
								{
									Sector[4] = 1;
									if(Sector[2]==1)
									{
										Debug.Log("Scale total");
										objeto.transform.localScale = new Vector3(1+0.1f,1+0.1f,1+0.1f);
									}
								}
								if(tmpxF1 < tmpxI1)
								{
									Sector[3] = 1;
									if(Sector[1]==1)
									{
										Debug.Log("Scale total");
										objeto.transform.localScale = new Vector3(1+0.1f,1+0.1f,1+0.1f);
									}
								}
							}
							if(diferenciaX1 < 50){
								Sector[7] = 1;
								if(Sector[5]==1)
								{
									Debug.Log("Scale a lo alto");
									objeto.transform.localScale = new Vector3(1,1+0.1f,1);
								}
							}
							//Debug.Log("Movimiento hacia abajo");
						}
						
						if(CoorInicial1 < CoorFinal1 ){
							
							if (diferenciaX1 > 50) 
							{
								if(tmpxF1 > tmpxI1)
								{
									Sector[1] = 1;
									if(Sector[3]==1)
									{
										Debug.Log("Scale total");
										objeto.transform.localScale = new Vector3(1+0.1f,1+0.1f,1+0.1f);
									}
								}
								if(tmpxF1 < tmpxI1)
								{
									Sector[2] = 1;
									if(Sector[4]==1)
									{
										Debug.Log("Scale total");
										objeto.transform.localScale = new Vector3(1+0.1f,1+0.1f,1+0.1f);
									}
								}
							}
							if(diferenciaX1 < 50)
							{
								Sector[5] = 1;
								if(Sector[7]==1)
								{
									Debug.Log("Scale a lo alto");
									objeto.transform.localScale = new Vector3(1,1+0.1f,1);
								}
							}
						}
					}
					if(Input.GetTouch (0).phase == TouchPhase.Ended && Input.GetTouch (1).phase == TouchPhase.Ended)
					{
						for(int i = 1; i <= 8; i++)
						{
							Sector[i]=0;
						}
					}
				}
			}
		} 
		else //con el mouse
		{
			if (Input.GetMouseButtonDown(0)==true)
			{
				tmpxI = Input.mousePosition.x;
				tmpyI = Input.mousePosition.y;
				//Debug.Log(tmpxI+ " " + tmpyI);
			}
			if(Input.mousePosition.x != tmpxI && Input.mousePosition.y != tmpyI)
			{
				tmpxF = Input.mousePosition.x;
				tmpyF = Input.mousePosition.y;
				
				if(tmpxI>tmpxF)
				{
					diferenciaX = tmpxI - tmpxF;
				}
				else
				{
					diferenciaX = tmpxF - tmpxI;
				}
				
				if(tmpyI>tmpyF)
				{
					diferenciaY = tmpyI - tmpyF;
				}
				else
				{
					diferenciaY = tmpyF - tmpyI;
				}
				
				if(Input.GetMouseButtonUp(0)==true)
				{
					if(diferenciaX > diferenciaY)
					{
						//Debug.Log("X mayor");
						CoorInicial = tmpxI;
						CoorFinal = tmpxF;

						
						if(CoorInicial > CoorFinal && diferenciaY < 50)
						{ 
							//Debug.Log("Movimiento a la izquierda");
						}
						if (CoorInicial > CoorFinal  && diferenciaY > 50) 
						{
							if(tmpyF > tmpyI)
							{
							}
							if(tmpyF < tmpyI)
							{
							}
						}
						if(CoorInicial < CoorFinal && diferenciaY < 50){
							//Debug.Log("Movimiento a la derecha");
							
						}
						if (CoorInicial < CoorFinal  && diferenciaY > 50) 
						{
							if(tmpyF > tmpyI)
							{
							}
							if(tmpyF < tmpyI)
							{
							}
						}
					}
					else
					{
						//Debug.Log("Y mayor");
						CoorInicial = tmpyI;
						CoorFinal = tmpyF;
						
						if(CoorInicial > CoorFinal)
						{
							if (diferenciaX > 50) 
							{
								if(tmpxF > tmpxI)
								{
								}
								if(tmpxF < tmpxI)
								{
								}
							}
							if(diferenciaX < 50){
							}
							//Debug.Log("Movimiento hacia abajo");
						}
						
						if(CoorInicial < CoorFinal )
						{
							
							if (diferenciaX > 50) 
							{
								if(tmpxF > tmpxI)
								{
								}
								if(tmpxF < tmpxI)
								{
								}
							}
							if(diferenciaX < 50)
							{
							}
							//Debug.Log("Movimiento hacia arriba");
						}
					}
				}
			}
		}
	}
	//-----------------------------------------------------------------
}
