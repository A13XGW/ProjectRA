using UnityEngine;
using System.Collections;

using UnityEngine.EventSystems;

using UnityEngine.UI;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject itemBeingDragged;
	public static GameObject itemBeingDraggedb;
	public static Vector3 startPosition;
	public static Transform startParent;
	public Image panel;

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		//throw new System.NotImplementedException ();

		//itemBeingDragged = Instantiate(gameObject);
		//itemBeingDragged.transform.SetParent(panel.transform);

		itemBeingDraggedb = Instantiate(gameObject);

		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		//throw new System.NotImplementedException ();
		transform.position = Input.mousePosition;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		//throw new System.NotImplementedException ();
		itemBeingDragged = null;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		/*if (transform.parent == startParent) {
			transform.position = startPosition;
		}*/
	}

	#endregion
}
