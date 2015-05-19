#pragma strict

import UnityEngine.UI;

import System.IO;

function SaveTextureToFile( texture: Texture2D,fileName)
{	
    var bytes=texture.EncodeToPNG();
    var file = new File.Open(Application.dataPath + "/"+fileName,FileMode.Create);
    var binary= new BinaryWriter(file);
    binary.Write(bytes);
    file.Close();
}

 //var myTexture: Texture2D;
 var Imagen: Image;

function Start () {
	SaveTextureToFile(Imagen.sprite.texture ,"picture.png");
}

function Update () {

}