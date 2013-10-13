﻿using UnityEngine;
using System.Collections;

public class D3_4 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){

		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGuy = 	"(Le lendemain, je suis allé la voir chez elle. J'étais" + "\n" + 
								"chanceux, son futur mari n'était pas là.)";
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		
		// Example
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new D3_5()); 		// change dialogue
			break;
		
		}
		
	}
	
	public void Exit(){

		buttons.reset();

	}
}