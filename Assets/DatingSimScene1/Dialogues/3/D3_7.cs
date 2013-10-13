using UnityEngine;
using System.Collections;

public class D3_7 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){

		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGuy = 	"D'accord" + "\n" + 
								"";
		//					"01234567890123456789" <- Max length (20 char)
		buttons.button1 = 	"Restaurant";
		buttons.button2 = 	"Centre d'achat";
		buttons.button3 = 	"Parc";
		buttons.button4 = 	"Prendre un verre";
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		
		// Example
		case 1:
			GererVariablesGlobales.getGererVariablesGlobales().relation += 10;
			DialogueManager.getDialogueManager().changeDialogue(new D3_7_1()); 		// change dialogue
			break;
		case 2:
			GererVariablesGlobales.getGererVariablesGlobales().relation += 20;
			DialogueManager.getDialogueManager().changeDialogue(new D3_7_2()); 		// change dialogue
			break;
		case 3:
			DialogueManager.getDialogueManager().changeDialogue(new D3_7_3()); 		// change dialogue
			break;
		case 4:
			GererVariablesGlobales.getGererVariablesGlobales().relation += 40;
			DialogueManager.getDialogueManager().changeDialogue(new D3_7_4()); 		// change dialogue
			break;
		
		}
		
	}
	
	public void Exit(){

		buttons.reset();

	}
	
}
