using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ImgAvatarGrupo : MonoBehaviour {
	public Image bandera;
	public Image Avatar;
	public GameObject ImgGrupo;
	public int ind;
	public GameObject PanelRegistro;
	public void OnButtonDown(){
		Avatar.sprite = bandera.sprite;
		PanelRegistro.GetComponent<Equipo> ().AEquipo = ind;
		ImgGrupo.SetActive (false);
	}
}
