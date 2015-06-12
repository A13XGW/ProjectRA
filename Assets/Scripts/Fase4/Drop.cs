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
	public  int slots = 1;
	public GameObject canvas;
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

				if(slots <= 5){//|| slots < 10 || slots < 15 || slots < 20 || slots < 25
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x+(referencia.GetComponent<RectTransform>().sizeDelta.x + (referencia.GetComponent<RectTransform>().sizeDelta.x * 0.20f)), grupoPrin.sizeDelta.y);
					transform.GetComponentInParent<DragGroup>().slots++;
					slots++;
				}
				if(slots == 5 || slots == 10){
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x, grupoPrin.sizeDelta.y+(referencia.GetComponent<RectTransform>().sizeDelta.y + (referencia.GetComponent<RectTransform>().sizeDelta.y * 0.20f)));
					transform.GetComponentInParent<DragGroup>().slots++;
					slots++;
				}
				GameObject tmp = Instantiate(slot);
				tmp.transform.SetParent(panelGrid.transform);

			DragHand.itemBeingDragged.transform.SetParent(transform);
			canvas.GetComponent<CargarImagenes>().imagenesCarrete -= 1;
			if(DragHand.startParent != transform && DragHand.startParent != panel.transform)
			{
				if(DragHand.startParent.GetComponentInParent<DragGroup>().slots>=2 ){
					DragHand.startParent.GetComponentInParent<DragGroup>().slots -= 1;
					Destroy(DragHand.startParent.gameObject);
				}
			}
		}
	}

	#endregion
}
