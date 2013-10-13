using UnityEngine;
using System.Collections;

public class D4_5 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGuy = 	"(Elle ne doit surtout pas m'oublier, je suis donc allé" + "\n" + 
								"la voir encore le lendemain)";
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new D4_6()); 		// change dialogue
			break;
		}
		
	}
	
	public void Exit(){
		// resetting parameters, to make sure everything is ok in the next dialogue (no residuals)
		buttons.reset();
	}
}
