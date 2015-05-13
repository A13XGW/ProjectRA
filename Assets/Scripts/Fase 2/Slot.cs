using UnityEngine;
using System.Collections;

using UnityEngine.EventSystems;

using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler {
	/*public GameObject item {
		get {
			if (transform.childCount>0){
				return transform.GetChild(0).gameObject;
			}
			return null;
		}
	}*/
	
	#region IDropHandler implementation
	
	public void OnDrop (PointerEventData eventData)
	{
		//throw new System.NotImplementedException ();
		//if (!item) {
			//DragHandeler.itemBeingDragged.transform.SetParent(transform);
		//}

		//Image prueba = Instantiate (DragHandeler.itemBeingDragged);

		DragHandeler.itemBeingDragged.transform.SetParent (transform);
		Vector3 percentsize = new Vector3 (1.0f, 1.5f);
		DragHandeler.itemBeingDragged.transform.localScale = percentsize;
		DragHandeler.itemBeingDragged.transform.position = Input.mousePosition;

		if (DragHandeler.itemBeingDragged.transform.parent != transform.parent) {
			DragHandeler.itemBeingDraggedb.transform.position = DragHandeler.startPosition;
			DragHandeler.itemBeingDraggedb.transform.SetParent (DragHandeler.startParent);
		}
	}
	
	#endregion
}