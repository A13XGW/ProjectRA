using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropItSlot : MonoBehaviour, IDropHandler {

	GameObject tmp;
	public GameObject slot;
	public RectTransform panelGrid;
	public GameObject panel;
	public RectTransform grupoPrin;
	public int slots = 1;
	public Image referencia;

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
			if(DraglerSlot.itemBeingDragged.transform.parent != transform.parent){
				if (slots < 5) {//Crece el grupo a lo ancho
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x + (referencia.GetComponent<RectTransform> ().sizeDelta.x + (referencia.GetComponent<RectTransform> ().sizeDelta.x * 0.20f)), grupoPrin.sizeDelta.y);
				}
				if(slots == 5 || slots == 10 ){//Crece el grupo a lo alto
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x, grupoPrin.sizeDelta.y+(referencia.GetComponent<RectTransform>().sizeDelta.y + (referencia.GetComponent<RectTransform>().sizeDelta.y * 0.20f)));
				}
				if (DraglerSlot.itemBeingDragged.transform.parent.tag == "carrete" ){//Reduce el carrete de imagenes
					panel.GetComponent<RectTransform>().sizeDelta = new Vector2 (panel.GetComponent<RectTransform>().sizeDelta.x - DragHand.itemBeingDragged.GetComponent<RectTransform>().sizeDelta.x - (DragHand.itemBeingDragged.GetComponent<RectTransform>().sizeDelta.x * 0.20f), panel.GetComponent<RectTransform>().sizeDelta.y);
				}
				slots++;
				if(slots<=15){
					tmp = Instantiate(slot);
					tmp.transform.SetParent(panelGrid.transform);
					tmp.transform.localScale = new Vector3(1f,1f,1f);
				}

				DraglerSlot.itemBeingDragged.transform.SetParent(transform);

				/*if (DraglerSlot.startParent.GetComponentInParent<DragGroup>()!=null && DraglerSlot.startParent != panel.transform)
				{
					if(DraglerSlot.startParent.GetComponentInParent<DragGroup>().slots>=2 ){
						DraglerSlot.startParent.GetComponentInParent<DragGroup>().slots -= 1;
						//tmp.GetComponent<Drop>().slots -=1;
						Destroy(DraglerSlot.startParent.gameObject);
					}
				}*/
			}
		}
	}
	#endregion
}
