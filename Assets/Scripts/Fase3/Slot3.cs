using UnityEngine;
using System.Collections;

using UnityEngine.EventSystems;

using UnityEngine.UI;

public class Slot3 : MonoBehaviour, IDropHandler {

	public Image lienzo;
	public Image panel;
	
	#region IDropHandler implementation
	
	public void OnDrop (PointerEventData eventData)
	{
		if (DragHandeler.startParent != panel.transform) {
			DragHandeler.itemBeingDragged.transform.SetParent (transform);
			Vector3 percentsize = new Vector3 (1.0f, 1.5f);
			DragHandeler.itemBeingDragged.transform.localScale = percentsize;
			DragHandeler.itemBeingDragged.transform.position = Input.mousePosition;
		} else {
			GameObject tmp = Instantiate(DragHandeler.itemBeingDragged);
			tmp.transform.position = DragHandeler.startPosition;
			tmp.transform.SetParent(DragHandeler.startParent);

			DragHandeler.itemBeingDragged.transform.SetParent (transform);
			Vector3 percentsize = new Vector3 (1.0f, 1.5f);
			DragHandeler.itemBeingDragged.transform.localScale = percentsize;
			DragHandeler.itemBeingDragged.transform.position = Input.mousePosition;
		}
	}
	
	#endregion
}