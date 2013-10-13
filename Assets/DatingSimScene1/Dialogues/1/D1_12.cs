using UnityEngine;
using System.Collections;

public class D1_12 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		
		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGuy = 	"Vous comprendrez donc le choc que j'ai reçu lorsqu'elle" + "\n" + 
								"m'a appris que son fiancé et elle allait se marier.";

		
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new D1_13()); 		// change dialogue
			break;
		
		}
		
	}
	
	public void Exit(){
		buttons.reset();
		
	}
}
