using UnityEngine;
using System.Collections;

public class D3_7_2 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){

		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGuy = 	"On pourrait aller au centre d'achat" + "\n" + 
								"";
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		
		// Example
		case 0:
			//Perdre des points
			DialogueManager.getDialogueManager().changeDialogue(new D3_7_2_1()); 		// change dialogue
			break;
		
		}
		
	}
	
	public void Exit(){

		buttons.reset();

	}
}
