using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Drop : MonoBehaviour, IDropHandler {
	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		throw new System.NotImplementedException ();
	}

	#endregion
}
