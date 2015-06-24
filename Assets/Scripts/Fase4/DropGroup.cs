using UnityEngine;
using System.Collections;

using UnityEngine.EventSystems;

using UnityEngine.UI;

public class DropGroup : MonoBehaviour, IDropHandler {
	public Transform lienzo;
	
	#region IDropHandler implementation
	
	public void OnDrop (PointerEventData eventData)
	{
		if (DragGroup.itemBeingDragged == null) {
		}
		else
		if (DragGroup.startParent == lienzo) {
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
