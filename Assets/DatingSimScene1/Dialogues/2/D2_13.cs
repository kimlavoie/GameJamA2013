using UnityEngine;
using System.Collections;

public class D2_13 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		GameObject girl = GameObject.Find("Girl");
		GirlMaterials materials = (GirlMaterials) girl.GetComponent("GirlMaterials");
		girl.renderer.material = materials.girlNeutral;
		// get the button manager, then change the text of the buttons to make them appear. button{ID} send the message ID when clicked
		
		// Example
		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGirl = 	"Bon, vient-en, tu me dois un verre!" + "\n" + 
								"";
		buttons.button1 = 	"OK";
		buttons.button2 = 	"Non";
		
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		
		case 1:
			GererVariablesGlobales.getGererVariablesGlobales().relation += 20;
			DialogueManager.getDialogueManager().changeDialogue(new D2_13_1()); 		// change dialogue
			break;
		case 2:
			DialogueManager.getDialogueManager ().changeDialogue (new D2_13_2());
			break;
		
		}
		
	}
	
	public void Exit(){
		
		buttons.reset();
		
	}
}
