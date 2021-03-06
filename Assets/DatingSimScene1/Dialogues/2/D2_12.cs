﻿using UnityEngine;
using System.Collections;

public class D2_12 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		// get the button manager, then change the text of the buttons to make them appear. button{ID} send the message ID when clicked
		
		// Example
		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGirl = 	"JE T'AI DIT D'ARRÊTER DE M'IGNORER!" + "\n" + 
								"";
		
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new D2_13()); 		// change dialogue
			break;
		
		}
		
	}
	
	public void Exit(){
		
		buttons.reset();
		
	}
}
