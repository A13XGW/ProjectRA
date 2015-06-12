using UnityEngine;
using System.Collections;

using UnityEngine.EventSystems;

using UnityEngine.UI;

public class DropGroup : MonoBehaviour, IDropHandler {
	public Image lienzo;
	public Transform canvas;
	
	#region IDropHandler implementation
	
	public void OnDrop (PointerEventData eventData)
	{
		if (DragGroup.itemBeingDragged == null) {
		}
		else
		if (DragGroup.startParent == canvas) {
			DragGroup.itemBeingDragged.transform.SetParent (transform);
			DragGroup.itemBeingDragged.transform.position = Input.mousePosition;
		} else {
			GameObject tmp = Instantiate(DragGroup.itemBeingDragged);
			//tmp.transform.position = DragGroup.startPosition;
			tmp.transform.SetParent(DragGroup.startParent);
			tmp.transform.GetComponent<CanvasGroup>().blocksRaycasts = true;
			
			DragGroup.itemBeingDragged.transform.SetParent (transform);
			DragGroup.itemBeingDragged.transform.position = Input.mousePosition;
		}
	}
	
	#endregion
}
