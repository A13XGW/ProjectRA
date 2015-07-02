﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraglerSlot : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler {
	
	public GameObject panel;
	public GameObject canvas;

	public static GameObject itemBeingDragged;
	public static Vector3 startPosition;
	public static Transform startParent;

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
		if (Input.touchSupported == true) {
			if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
				Vector2 tch = Input.GetTouch(0).deltaPosition;
				transform.position = new Vector2 (tch.x,tch.y);
				//transform.SetParent(canvas.transform);
			}
		} else {
			transform.position = Input.mousePosition;
			//transform.SetParent(canvas.transform);
		}
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
		}

	}

	#endregion





}
