using UnityEngine;
using System.Collections;

public class scriptGameOver : MonoBehaviour {

public GUISkin myskin;
public Texture2D backgroundGameOver;
public Texture2D LOGO;
	

	private string clicked = "";
	
	private void OnGUI()
	{
		//Background
		if(backgroundGameOver != null)
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundGameOver);
		if(LOGO != null)
		{
				GUI.DrawTexture(new Rect(Screen.width/2-100,100,200,50),LOGO);
				GUIStyle gameOverStyle = new GUIStyle(GUI.skin.GetStyle("Box"));
				gameOverStyle.alignment = TextAnchor.UpperCenter;
				gameOverStyle.normal.textColor = Color.red;
				gameOverStyle.hover.textColor = Color.red;
				gameOverStyle.active.textColor = Color.red;
				gameOverStyle.fontSize = Screen.height/24;
				GUI.Box (new Rect(0,200,Screen.width,Screen.height/16),"Votre esprit a sombré dans l'étendu infini du néant",gameOverStyle);
		}
	
		if(clicked == "")
		{
			if (GUI.Button(new Rect((Screen.width/2-100),(Screen.height/2),200,30), "Quitter le jeu"))
				clicked = "quitter";
		}

		else if(clicked == "quitter")
			Application.Quit();	
	}
	
		
}
