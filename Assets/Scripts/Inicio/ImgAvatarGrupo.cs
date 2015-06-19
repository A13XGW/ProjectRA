using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ImgAvatarGrupo : MonoBehaviour {
	public Image bandera;
	public Image Avatar;
	public GameObject ImgGrupo;
	public void OnButtonDown(){
		Avatar.sprite = bandera.sprite;
		ImgGrupo.SetActive (false);
	}
}
