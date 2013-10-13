using UnityEngine;
using System.Collections;

public class GUIButtonsScript : MonoBehaviour {
	
	public Font font;
	
	public string buttonGirl = 	"";
	public string buttonGuy = 	"";
	public string button1 = 	"";
	public string button2 = 	"";
	public string button3 = 	"";
	public string button4 = 	"";
	
	private void OnGUI(){
		
		/***************************Colors*********************************/
		Color girlColor 	= 	Color.magenta; 
		Color guyColor 		= 	Color.cyan;
		Color generalColor 	=	Color.white;
		
		/***************************Styles*********************************/
		// Girl - Stacey
		GUIStyle styleGirl	 	= generateStyle(girlColor);
		
		// Guy - Chad
		GUIStyle styleGuy 		= generateStyle(guyColor);
		
		// General style
		GUIStyle styleButtons 	= generateStyle(generalColor);
		
		
		/*********************Set buttons and messages*********************/
		// Girl - Stacey
		if(!buttonGirl.Equals("")){
			if(GUI.Button(	new Rect(	0,
										0,
										Screen.width,
										Screen.height/10), 
							buttonGirl, 
							styleGirl )){
				DialogueManager.getDialogueManager().sendMessage(0);
			}
		}
		
		// Guy - Chad
		if(!buttonGuy.Equals("")){
			if(GUI.Button(	new Rect(	0,
										Screen.height-Screen.height/10,
										Screen.width,
										Screen.height/10), 
							buttonGuy, 
							styleGuy)){
				DialogueManager.getDialogueManager().sendMessage(0);
			}
		}
		
		// Option 1 - Upper left
		if(!button1.Equals("")){
			if(GUI.Button(	new Rect(	0,
										Screen.height/2-Screen.height/4,
										Screen.width/3,
										Screen.height/20), 
							button1, 
							styleButtons)){
				DialogueManager.getDialogueManager().sendMessage(1);
			}
		}
		
		// Option 2 - Upper right
		if(!button2.Equals("")){
			if(GUI.Button(	new Rect(	Screen.width-Screen.width/3,
										Screen.height/2-Screen.height/4,
										Screen.width/3,
										Screen.height/20), 
							button2, 
							styleButtons)){
				DialogueManager.getDialogueManager().sendMessage(2);
			}
		}
		
		// Option 3 - Lower left
		if(!button3.Equals("")){
			if(GUI.Button(	new Rect(	0,
										Screen.height/2 + Screen.height/4,
										Screen.width/3,
										Screen.height/20), 
							button3, 
							styleButtons)){
				DialogueManager.getDialogueManager().sendMessage(3);
			}
		}
		
		// Option 4 - Lower right
		if(!button4.Equals("")){
			if(GUI.Button(	new Rect(	Screen.width-Screen.width/3,
										Screen.height/2+Screen.height/4,
										Screen.width/3,
										Screen.height/20), 
							button4, 
							styleButtons)){
				DialogueManager.getDialogueManager().sendMessage(4);
			}
		}
		
	}
	
	public GUIStyle generateStyle(Color color){
		/*
		 * Create the correct style from color
		 */
		GUIStyle style = new GUIStyle(GUI.skin.GetStyle("Button"));
		style.alignment = TextAnchor.UpperCenter;
		style.normal.textColor = color;
		style.hover.textColor = color;
		style.active.textColor = color;
		style.font = font;
		style.fontSize = Screen.height/24;
		return style;
	}
	
	public void reset(){
		/*
		 * Reset all strings, to clear buttons
		 */
		buttonGuy = "";
		buttonGirl = "";
		button1 = "";
		button2 = "";
		button3 = "";
		button4 = "";
	}
}
