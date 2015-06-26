using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ArrastraMano : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject itemBeingDragged;
	static Vector3 startPosition;
	public static Transform startParent;
	public GameObject panel;
	public GameObject canvas;
	public GameObject panelPadre;

	#region IBeginDragHandler implementation
	
	public void OnBeginDrag (PointerEventData eventData)
	{




		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;

	}
	
	#endregion
	
	#region IDragHandler implementation
	
	public void OnDrag (PointerEventData eventData)
	{
		transform.position = Input.mousePosition;

			GetComponent<GirarImagen> ().Velocidadx = 0;
			GetComponent<GirarImagen> ().Velocidady = 0;
		
	}
	
	#endregion
	
	#region IEndDragHandler implementation
	
	public void OnEndDrag (PointerEventData eventData)
	{
		itemBeingDragged = null;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		if(transform.parent == startParent)
		{

			transform.position = startPosition;

			if(transform.parent== panelPadre){
				GetComponent<GirarImagen>().Velocidadx=0.005F;
				GetComponent<GirarImagen>().Velocidady=0.005F;
			}
		}
		if (transform.parent == panel.transform || transform.parent == canvas.transform) {

			transform.position = startPosition;
	
		} 
	}

	
	#endregion
}
