using UnityEngine;
using System.Collections;

public class D1_1 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){	
		GameObject girl = GameObject.Find("Girl");
		girl.renderer.enabled = false;
		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGuy = 	"Je n'ai jamais pu supporter cette ville." + "\n" + 
								"";

		
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new D1_2()); 		// change dialogue
			break;
		
		}
		
	}
	
	public void Exit(){
		buttons.reset();
		
	}
}
