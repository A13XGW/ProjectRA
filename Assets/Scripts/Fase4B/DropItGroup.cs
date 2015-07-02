using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropItGroup : MonoBehaviour, IDropHandler {
	public GameObject item 	{
		get	{
			if(transform.childCount>0)	{
				return transform.GetChild(0).gameObject;
			}
			return null;
		}
	}

	#region IDropHandler implementation
	public void OnDrop (PointerEventData eventData)
	{
		if (!item) {
			Dragler.itemBeingDragged.transform.SetParent(transform);
			Dragler.itemBeingDragged.transform.position = transform.position;
		}
	}
	#endregion
}
