using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Drop_1 : MonoBehaviour, IDropHandler {
	public int padre;
	public GameObject item 	{
		get	{
			if(transform.childCount>0)	{
				return transform.GetChild(0).gameObject;
			}
			return null;
		}
	}

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)	{
	
		if (!item) {
			if(DragHand_1.itemBeingDragged!=null)
			{
				if (DragHand_1.itemBeingDragged.transform.name == transform.name){
					DragHand_1.itemBeingDragged.transform.SetParent(transform);
					DragHand_1.startParent.GetComponent<Contador>().contadorR +=1;
				}
			}
		
		}

	}

	#endregion
}
