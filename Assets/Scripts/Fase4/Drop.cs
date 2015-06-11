using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Drop : MonoBehaviour, IDropHandler {
	public Image panel;
	public Image slot;
	public Image[] grupo;
	public RectTransform panelGrid;
	public Image referencia;
	public RectTransform grupoPrin;
	int slots = 1;
	int slotg = 1;
	public GameObject item 	{
		get	{
			if(transform.childCount>0)	{
				return transform.GetChild(0).gameObject;
			}
			return null;
		}
	}
	void Start(){
		grupo = new Image[30];
	}
	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)	{
		if (!item) {
			do{
				if(slots < 5){//|| slots < 10 || slots < 15 || slots < 20 || slots < 25
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x+(referencia.GetComponent<RectTransform>().sizeDelta.x + (referencia.GetComponent<RectTransform>().sizeDelta.x * 0.20f)), grupoPrin.sizeDelta.y);
				}else{
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x, grupoPrin.sizeDelta.y+(referencia.GetComponent<RectTransform>().sizeDelta.y + (referencia.GetComponent<RectTransform>().sizeDelta.y * 0.20f)));;
				}
				grupo[slots] = Instantiate(slot);
				grupo[slots].transform.SetParent(panelGrid.transform);
				slots++;
				slotg++;
			}while(slotg == 1);
			slotg = 1;
			DragHand.itemBeingDragged.transform.SetParent(transform);
		}
		/*if (DragHand.startParent != panel.transform) {
			DragHand.itemBeingDragged.transform.SetParent (transform);
			Vector3 percentsize = new Vector3 (1.0f, 1.5f);
			DragHand.itemBeingDragged.transform.localScale = percentsize;
			//DragHandeler.itemBeingDragged.transform.position = Input.mousePosition;
		}*/
	}

	#endregion
}
