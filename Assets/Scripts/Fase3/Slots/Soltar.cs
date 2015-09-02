using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Soltar : MonoBehaviour, IDropHandler {
	public int padre;
	public Image imagen;
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
			if (ArrastraMano.itemBeingDragged!=null) {
				if (ArrastraMano.itemBeingDragged.transform.name == transform.name)
				{
					//Debug.Log ("Entra");
					ArrastraMano.itemBeingDragged.gameObject.GetComponent<GirarImagen>().girarObj=false;
			
					ArrastraMano.itemBeingDragged.transform.SetParent(transform);

					ArrastraMano.startParent.GetComponent<Contador>().contadorR +=1;
					//StartCoroutine(TraerFrente());
				} 

			}
		}

	}

	#endregion
	IEnumerator TraerFrente(){
		yield return new WaitForSeconds(1);
		imagen.gameObject.SetActive (true);
	}
}
