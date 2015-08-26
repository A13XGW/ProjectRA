using UnityEngine;
using System.Collections;
//using UnityEditor;
using UnityEngine.UI;
public class metas : MonoBehaviour {
	public Image img;
	public int tamano;
	Zoom miZoom = new Zoom();
	//metas miUpdate = new metas();
	string MiNombre;
	void Update(){
		if (img.transform.parent.name == "Area de Trabajo") 
		{
			tamano = miZoom.zoom (img);
		}
	}
	public void OnPointerClick(){
		Update();
//		MiNombre = img.mainTexture.name;
//		TextureImporter tImporter = AssetImporter.GetAtPath("Assets/Resources/Face2/"+MiNombre+".png") as TextureImporter;
//		tImporter.mipmapEnabled = true;
//		tImporter.isReadable = true;
//		tImporter.maxTextureSize = tamano;
//		AssetDatabase.ImportAsset( "Assets/Resources/Face2/"+MiNombre+".png", ImportAssetOptions.ForceUpdate );
	}

}
