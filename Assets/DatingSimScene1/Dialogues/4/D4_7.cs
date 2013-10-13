using UnityEngine;
using System.Collections;

public class D4_7 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGuy = 	"… huh … apparemment …" + "\n" + 
								"";
		//					"01234567890123456789" <- Max length (20 char)
		buttons.button1 = 	"Promenade au parc";
		buttons.button2 = 	"Diner au bistro";
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		case 1:
			DialogueManager.getDialogueManager().changeDialogue(new D4_7_1()); 		// change dialogue
			break;
		case 2:
			GererVariablesGlobales.getGererVariablesGlobales().relation += 50;
			DialogueManager.getDialogueManager().changeDialogue(new D4_7_2()); 		// change dialogue
			break;
		}
		
	}
	
	public void Exit(){
		// resetting parameters, to make sure everything is ok in the next dialogue (no residuals)
		buttons.reset();
	}
}
