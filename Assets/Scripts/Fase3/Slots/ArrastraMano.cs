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


	public Image imagen;

	#region IBeginDragHandler implementation
	
	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
		if(startParent.tag != "slot")
		{
			itemBeingDragged.GetComponent<CanvasGroup>().blocksRaycasts = true;
			itemBeingDragged.transform.position = DragHandeler.startPosition;
			itemBeingDragged.transform.SetParent(DragHandeler.startParent);
			itemBeingDragged.transform.localScale = new Vector3(1,1,1);
			itemBeingDragged.GetComponent<CanvasGroup> ().blocksRaycasts = false;
		}

//		itemBeingDragged = gameObject;
//		startPosition = transform.position;
//		startParent = transform.parent;
//		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}
	
	#endregion
	
	#region IDragHandler implementation
	
	public void OnDrag (PointerEventData eventData)
	{

		if (Input.touchSupported == true) 
		{
			if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
			{
				Vector2 tch = Input.GetTouch(0).deltaPosition;
				transform.position = new Vector2 (tch.x,tch.y);
			}
		} 
		else 
		{
			transform.position = Input.mousePosition;
		}
		//transform.position = Input.mousePosition;

			
			GetComponent<GirarImagen> ().Velocidadx = 0;
			GetComponent<GirarImagen> ().Velocidady = 0;		
			
	}
	
	#endregion
	
	#region IEndDragHandler implementation
	
	public void OnEndDrag (PointerEventData eventData)
	{

		itemBeingDragged = null;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		if(transform.tag != "slot")
		{
			if(transform.parent == startParent)
			{
				transform.position = startPosition;
			}
		}

/*		if (transform.parent == panel.transform || transform.parent == canvas.transform) 
		{		
			Debug.Log ("Entra");
			transform.position = startPosition;
		}*/
		if (GetComponent<GirarImagen> ().girarObj==true) {
			GetComponent<GirarImagen> ().girarObj=false;
			//GetComponent<GirarImagen> ().Velocidadx = 0.005F;
			//GetComponent<GirarImagen> ().Velocidady = 0.005F;
			//imagen.gameObject.SetActive (true);
		} else {
			GetComponent<GirarImagen> ().Velocidadx = 0;
			GetComponent<GirarImagen> ().Velocidady = 0;
		}


	}

	
	#endregion
}
