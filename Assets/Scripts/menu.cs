using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour
{
	public GUISkin myskin;
	public Texture2D background, LOGO;

	

	private string clicked = "";
	
	private void OnGUI()
	{
		//Background
		if(background != null)
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),background);
		
		if(clicked == "" || clicked == "propos")
		{
			//LOGO
			if(LOGO != null)
				GUI.DrawTexture(new Rect(Screen.width/2-100,30,200,200),LOGO);
		}
	
		if(clicked == "")
		{
			//Buttons
			GUI.skin = myskin;
			if (GUI.Button(new Rect((Screen.width/2-100),(Screen.height/2),200,30), "Jouer"))
			{
				clicked = "jouer";
			}
			
			if (GUI.Button(new Rect((Screen.width/2-100),(Screen.height/2+50),200,30), "À Propos"))
			{
				clicked = "propos";
			}
			if (GUI.Button(new Rect((Screen.width/2-100),(Screen.height/2+100),200,30), "Quitter le jeu"))
			{
				clicked = "quitter";
			}
			
		}
		else if(clicked == "jouer")
		{
			Application.LoadLevel("DatingSimScene1");
		}
			
	
		else if(clicked == "propos")
		{
			GUIStyle proposStyle = new GUIStyle(GUI.skin.GetStyle("Box"));
			proposStyle.alignment = TextAnchor.MiddleCenter;
			proposStyle.normal.textColor = Color.green;
			proposStyle.hover.textColor = Color.green;
			proposStyle.active.textColor = Color.green;
			proposStyle.fontSize = Screen.height/36;
			GUI.Box(new Rect(50,Screen.height/2-75,Screen.width-100,50), "Appuyez sur Entrez ou sur une phrase pour poursuivre le dialogue",proposStyle);
			GUI.Box(new Rect(50,Screen.height/2,Screen.width-100,50), "Dans la platforme, utilisez les fleches pour déplacer votre personnage",proposStyle);
			GUI.Box(new Rect(50,Screen.height/2+75,Screen.width-100,50), "Appuyez sur espace pour sauter",proposStyle);
		}
			
		else if(clicked == "quitter")
				Application.Quit();	
	}
	
	private void Update()
	{
		if(clicked == "propos" && Input.GetKey(KeyCode.Escape))
		{
			clicked = "";
		}
	}
	
}
