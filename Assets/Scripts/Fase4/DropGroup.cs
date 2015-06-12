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
		if (DragHand.itemBeingDragged == null) {
		}
		else
		if (DragHand.startParent == canvas) {
			DragHand.itemBeingDragged.transform.SetParent (transform);
			DragHand.itemBeingDragged.transform.position = Input.mousePosition;
		} else {
			GameObject tmp = Instantiate(DragHand.itemBeingDragged);
			//tmp.transform.position = DragHand.startPosition;
			tmp.transform.SetParent(DragHand.startParent);
			tmp.transform.GetComponent<CanvasGroup>().blocksRaycasts = true;
			
			DragHand.itemBeingDragged.transform.SetParent (transform);
			DragHand.itemBeingDragged.transform.position = Input.mousePosition;
		}
	}
	
	#endregion
}
