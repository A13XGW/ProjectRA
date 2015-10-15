using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DragHand : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject itemBeingDragged;
	static Vector3 startPosition;
	public static Transform startParent;
	public GameObject panel;
	public GameObject canvas;
	public int validar=0;

	void Update()
	{
		if (Input.GetMouseButton(0)) {
			if(Input.mousePosition.x >= 1260)
			{
				Debug.Log("area");
				transform.position = startPosition;
				Input.mousePosition.Set(startPosition.x,startPosition.y,startPosition.z);
				//return;
			}
		}

	}
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
		if (transform.parent.tag == "slot") {
			validar =1;
		}
		//transform.SetParent(canvas.transform);


		//transform.parent = canvas.transform;
	}
	
	#endregion
	
	#region IEndDragHandler implementation
	
	public void OnEndDrag (PointerEventData eventData)
	{
		Debug.Log (Input.mousePosition);
		itemBeingDragged = null;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		if(transform.parent == startParent)
		{
			transform.position = startPosition;
		}
		if (transform.parent == panel.transform || transform.parent == canvas.transform) {
			transform.position = startPosition;
			transform.parent = startParent;
		}
		validar = 0;

	}
	
	#endregion
}
