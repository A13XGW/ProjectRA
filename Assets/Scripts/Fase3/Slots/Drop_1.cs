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
		
			
			/*
				if(slots <= 5){//|| slots < 10 || slots < 15 || slots < 20 || slots < 25
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x+(referencia.GetComponent<RectTransform>().sizeDelta.x + (referencia.GetComponent<RectTransform>().sizeDelta.x * 0.20f)), grupoPrin.sizeDelta.y);
					transform.GetComponentInParent<DragGroup_1>().slots++;
					Debug.Log(slots);
				}
				if(slots == 5 || slots == 10){
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x, grupoPrin.sizeDelta.y+(referencia.GetComponent<RectTransform>().sizeDelta.y + (referencia.GetComponent<RectTransform>().sizeDelta.y * 0.20f)));
					transform.GetComponentInParent<DragGroup_1>().slots++;
				}
				GameObject tmp = Instantiate(slot);
				tmp.transform.SetParent(panelGrid.transform);
*/
			if (DragHand_1.itemBeingDragged.transform.name == transform.name){
				DragHand_1.itemBeingDragged.transform.SetParent(transform);
				DragHand_1.startParent.GetComponent<Contador>().contadorR +=1;
			}
		/*	if(DragHand_1.startParent != transform && DragHand_1.startParent != panel.transform)
			{
				if(DragHand_1.startParent.GetComponentInParent<DragGroup_1>().slots>=2 ){
					DragHand_1.startParent.GetComponentInParent<DragGroup_1>().slots -= 1;
					//transform.GetComponentInParent<DragGroup>().slots-=1;
					Destroy(DragHand_1.startParent.gameObject);
				}
			}*/
		}

	}

	#endregion
}
