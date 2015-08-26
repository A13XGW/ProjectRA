using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropItSlot : MonoBehaviour, IDropHandler 
{

	public GameObject canvas;
	GameObject tmp;
	public GameObject slot;
	public RectTransform panelGrid;
	public GameObject panel;
	public RectTransform grupoPrin;
	public int slots = 1;
	public Image referencia;

	public GameObject item 	
	{
		get	
		{
			if(transform.childCount>0)	
			{
				return transform.GetChild(0).gameObject;
			}
			return null;
		}
	}
	#region IDropHandler implementation
	public void OnDrop (PointerEventData eventData)
	{
		if (!item) 
		{
			if(Dragler.itemBeingDragged.transform.parent.parent != transform.parent)
			{//Si el padre del slot es el mismo no hacer nada
				if (slots < 5) 
				{//Crece el grupo a lo ancho
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x + (referencia.GetComponent<RectTransform> ().sizeDelta.x + (referencia.GetComponent<RectTransform> ().sizeDelta.x * 0.20f)), grupoPrin.sizeDelta.y);
				}
				if(slots == 5 || slots == 10 )
				{//Crece el grupo a lo alto
					grupoPrin.sizeDelta = new Vector2 (grupoPrin.sizeDelta.x, grupoPrin.sizeDelta.y+(referencia.GetComponent<RectTransform>().sizeDelta.y + (referencia.GetComponent<RectTransform>().sizeDelta.y * 0.20f)));
				}
				if (Dragler.itemBeingDragged.transform.parent.tag == "carrete" )
				{//Reduce el carrete de imagenes
					canvas.GetComponent<CargarImagenes>().imagenesCarrete -= 1;//Reduce el contador 
					if(canvas.GetComponent<CargarImagenes>().imagenesCarrete <= canvas.GetComponent<CargarImagenes>().thumbs.Length)
					{
						panel.GetComponent<RectTransform>().sizeDelta = new Vector2 (panel.GetComponent<RectTransform>().sizeDelta.x - Dragler.itemBeingDragged.GetComponent<RectTransform>().sizeDelta.x - (Dragler.itemBeingDragged.GetComponent<RectTransform>().sizeDelta.x * 0.20f), panel.GetComponent<RectTransform>().sizeDelta.y);
					}
				}
				slots++;
				transform.GetComponentInParent<Dragler>().slots++;
				if(slots<=15)
				{//Para que el grupo no crezca mas alla de los 15 slot
					tmp = Instantiate(slot);
					tmp.transform.SetParent(panelGrid.transform);
					tmp.transform.localScale = new Vector3(1f,1f,1f);
				}

				Dragler.itemBeingDragged.transform.SetParent(transform);

				if (Dragler.startParent.GetComponentInParent<Dragler>()!=null && Dragler.startParent != panel.transform)
				{//Destruye
					if(Dragler.startParent.GetComponentInParent<Dragler>().slots>=2 )
					{
						Dragler.startParent.GetComponentInParent<Dragler>().slots -= 1;
						Destroy(Dragler.startParent.gameObject);
					}
				}
			}
		}
	}
	#endregion
}
