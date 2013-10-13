using UnityEngine;
using System.Collections;

public class scriptWinScene : MonoBehaviour {

public GUISkin myskin;
public Texture2D backgroundWinScene;
private string clicked = "";
	
	private void OnGUI()
	{
		//Background
		if(backgroundWinScene != null)
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundWinScene);
			GUIStyle gameOverStyle = new GUIStyle(GUI.skin.GetStyle("Box"));
			gameOverStyle.alignment = TextAnchor.UpperCenter;
			gameOverStyle.normal.textColor = Color.blue;
			gameOverStyle.hover.textColor = Color.blue;
			gameOverStyle.active.textColor = Color.blue;
			gameOverStyle.fontSize = Screen.height/24;
			GUI.Box (new Rect(0, Screen.height-50,Screen.width,Screen.height/16),"Félicitations!! Vous vivrez le bonheur éternel avec Stacey!",gameOverStyle);
	
	
		if(clicked == "")
		{
			if (GUI.Button(new Rect((Screen.width/2-100),(Screen.height/2 + Screen.height/4),200,30), "Quitter le jeu"))
				clicked = "quitter";
		}

		else if(clicked == "quitter")
			Application.Quit();	
	}
	
		
}