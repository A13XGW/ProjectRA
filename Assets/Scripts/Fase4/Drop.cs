using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Drop : MonoBehaviour, IDropHandler {
	public Image panel;
	public GameObject slot;
	public RectTransform panelGrid;
	public Image referencia;
	public RectTransform grupoPrin;
	public int slots = 1;
	int slotg = 1;
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
			do{
				if(slots <= 5){//|| slots < 10 || slots < 15 || slots < 20 || slots < 25
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x+(referencia.GetComponent<RectTransform>().sizeDelta.x + (referencia.GetComponent<RectTransform>().sizeDelta.x * 0.20f)), grupoPrin.sizeDelta.y);
					slots++;
					Debug.Log(slots);
				}
				if(slots == 5 || slots == 10){
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x, grupoPrin.sizeDelta.y+(referencia.GetComponent<RectTransform>().sizeDelta.y + (referencia.GetComponent<RectTransform>().sizeDelta.y * 0.20f)));
					slots++;
				}
				GameObject tmp = Instantiate(slot);
				tmp.transform.SetParent(panelGrid.transform);
				Debug.Log(panelGrid.transform.parent.tag);
				tmp.tag = panelGrid.transform.parent.tag;
				slotg++;
			}while(slotg == 1);
			slotg = 1;
			DragHand.itemBeingDragged.transform.SetParent(transform);
			if(DragHand.startParent != transform && DragHand.startParent != panel.transform)
			{
				if(slots >= 2 && DragHand.startParent.GetComponent<Drop>().slots>=2){
					DragHand.startParent.GetComponent<Drop>().slots = DragHand.startParent.GetComponent<Drop>().slots-1;
					Debug.Log(DragHand.startParent.GetComponent<Drop>().slots);
					Destroy(DragHand.startParent.gameObject);
					slots--;
				}
			}
		}
	}

	#endregion
}
