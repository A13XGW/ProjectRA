using UnityEngine;
using System.Collections;

using UnityEngine.EventSystems;

using UnityEngine.UI;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject itemBeingDragged;
	public static Vector3 startPosition;
	public static Transform startParent;
	public  GameObject AreaDeTrabajo, AreaFondo, panel;
	GameObject tmp;
	public GameObject canvas;

	/*void Start()
	{
		if (Input.touchSupported == true) {//Validacion del soprte de touch
			if(transform.GetComponent<Button>() != null)
				transform.GetComponent<Button> ().enabled = true;
		} else {
			if(transform.GetComponent<Button>() != null)
				transform.GetComponent<Button> ().enabled = false;
		}
	}*/

	/*void OnMouseDown()
	{
		canvas.GetComponent<Gestos> ().objeto = transform.GetComponent<Image> ();
	}
	public void OnTouchDown()
	{
		canvas.GetComponent<Gestos> ().objeto = transform.GetComponent<Image> ();
	}*/

	#region IBeginDragHandler implementation
	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;



		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
		if (itemBeingDragged.transform.parent.tag == "guupo") {
			canvas.GetComponent <CargarImgs> ().agrupados--;
		}

		if(startParent.tag == "carrete")
		{
			tmp = Instantiate(DragHandeler.itemBeingDragged);
			tmp.GetComponent<CanvasGroup>().blocksRaycasts = true;
			tmp.transform.position = DragHandeler.startPosition;
			tmp.transform.SetParent(DragHandeler.startParent);
			tmp.transform.localScale = new Vector3(1,1,1);
			tmp.GetComponent<CanvasGroup> ().blocksRaycasts = false;
			//tmp.GetComponent<Image>().preserveAspect = false;
			itemBeingDragged = tmp;

		}

		/*if (startParent.tag != "Area De Trabajo") 
		{
			canvas.GetComponent<Gestos> ().objeto = tmp.GetComponent<Image> ();
		} else 
		{
			canvas.GetComponent<Gestos> ().objeto = itemBeingDragged.GetComponent<Image> ();
		}*/
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		if (Input.touchSupported == true) 
		{
			if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
			{
				Vector2 tch = Input.GetTouch(0).deltaPosition;
				itemBeingDragged.transform.position = new Vector2 (tch.x,tch.y);
				itemBeingDragged.GetComponent<Image>().type = Image.Type.Filled;
				if(Input.GetTouch(0).position.x >= 1260 || Input.GetTouch(0).position.x <= 20 || Input.GetTouch(0).position.y >= 580 || Input.GetTouch(0).position.y <= 20)
				{
					itemBeingDragged.transform.position = startPosition;
					Input.GetTouch(0).position.Set(startPosition.x,startPosition.y);
					return;
				}
			}
		} 
		else 
		{
			if (Input.GetMouseButton(0)) { //estaba y en 580
				if(Input.mousePosition.x >= 1260 || Input.mousePosition.y >= 700 || Input.mousePosition.x <= 20 || Input.mousePosition.y <= 20)
				{
					//				Debug.Log("area");
					itemBeingDragged.transform.position = startPosition;
					Input.mousePosition.Set(startPosition.x,startPosition.y,startPosition.z);
					return;
				}
			}
			itemBeingDragged.transform.position = Input.mousePosition;
		}

	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{

		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		if (startParent.tag != "Area De Trabajo") 
		{
			if(tmp != null){
				tmp.GetComponent<CanvasGroup> ().blocksRaycasts = true;
			}
			itemBeingDragged.GetComponent<CanvasGroup> ().blocksRaycasts = true;
		}
		if(itemBeingDragged.transform.parent == panel)
		{
			itemBeingDragged.transform.position = startPosition;
		}
		tmp = null;
		itemBeingDragged = null;
		Espera (0.50f);
	}

	#endregion
	IEnumerator Espera(float waitTime) {
		yield return new WaitForSeconds(waitTime);
	}
}
