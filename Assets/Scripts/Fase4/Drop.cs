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
	GameObject tmp;
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
			
			if(slots < 5){//|| slots < 10 || slots < 15 || slots < 20 || slots < 25
				grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x+(referencia.GetComponent<RectTransform>().sizeDelta.x + (referencia.GetComponent<RectTransform>().sizeDelta.x * 0.20f)), grupoPrin.sizeDelta.y);
			}
			
			if(slots == 5 || slots == 10 ){
				grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x, grupoPrin.sizeDelta.y+(referencia.GetComponent<RectTransform>().sizeDelta.y + (referencia.GetComponent<RectTransform>().sizeDelta.y * 0.20f)));
			}
			if(panel.GetComponent<RectTransform>()!=null && DragHand.itemBeingDragged!=null){
				if (DragHand.itemBeingDragged.transform.tag == "slot" )
					panel.GetComponent<RectTransform>().sizeDelta = new Vector2 (panel.GetComponent<RectTransform>().sizeDelta.x - DragHand.itemBeingDragged.GetComponent<RectTransform>().sizeDelta.x - (DragHand.itemBeingDragged.GetComponent<RectTransform>().sizeDelta.x * 0.20f), panel.GetComponent<RectTransform>().sizeDelta.y);
			}
			slots++;
			transform.GetComponentInParent<DragGroup>().slots++;
			
			if(slots<=15){
				tmp = Instantiate(slot);
				tmp.transform.SetParent(panelGrid.transform);
				tmp.transform.localScale = new Vector3(1f,1f,1f);
			}
			if(DragHand.itemBeingDragged!=null)
			{
				if(transform != null)
				{
					if(DragHand.itemBeingDragged.GetComponent<DragHand>().validar != 1){
						canvas.GetComponent<CargarImagenes>().imagenesCarrete -= 1;
					}
					DragHand.itemBeingDragged.transform.SetParent(transform);
					
					if(DragHand.startParent != null){
						if(DragHand.startParent != transform && DragHand.startParent != panel.transform)
						{
							if (DragHand.startParent.GetComponentInParent<DragGroup>()!=null) {
								if(DragHand.startParent.GetComponentInParent<DragGroup>().slots>=2 ){
									DragHand.startParent.GetComponentInParent<DragGroup>().slots -= 1;
									tmp.GetComponent<Drop>().slots -=1;
									Destroy(DragHand.startParent.gameObject);
								}
							}
						}
					}
				}
			}
		}
	}
	
	#endregion
}
