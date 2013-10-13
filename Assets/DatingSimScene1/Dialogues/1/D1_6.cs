using UnityEngine;
using System.Collections;

public class D1_6 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		
		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGuy = 	"Ne croyez pas que c'est un sobriquet que les autres me" + "\n" + 
								"donne, ce mot vient de moi.";

		
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new D1_7()); 		// change dialogue
			break;
		
		}
		
	}
	
	public void Exit(){
		buttons.reset();
		
	}
}
