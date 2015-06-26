using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Soltar : MonoBehaviour, IDropHandler {
	public int padre;
	public GameObject item 	{
		get	{
			if(transform.childCount>0)	{
				return transform.GetChild(0).gameObject;
			}
			return null;
		}
	}

	#region ArrastrarGrupo implementation

	public void OnDrop (PointerEventData eventData)	{
	
		if (!item) {

			if (ArrastraMano.itemBeingDragged.transform.name == transform.name){
				ArrastraMano.itemBeingDragged.transform.SetParent(transform);
				ArrastraMano.startParent.GetComponent<Contador>().contadorR +=1;
		
			}
		}

	}

	#endregion
}
