﻿using UnityEngine;
using System.Collections;

public class D4_2 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGirl = 	"C'était très comique, à la prochaine!" + "\n" + 
								"";
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new D4_3()); 		// change dialogue
			break;
		}
		
	}
	
	public void Exit(){
		// resetting parameters, to make sure everything is ok in the next dialogue (no residuals)
		buttons.reset();
	}
}