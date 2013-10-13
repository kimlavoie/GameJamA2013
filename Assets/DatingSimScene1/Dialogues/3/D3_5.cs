using UnityEngine;
using System.Collections;

public class D3_5 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		GameObject girl = GameObject.Find("Girl");
		girl.renderer.enabled = true;
		GirlMaterials materials = (GirlMaterials) girl.GetComponent("GirlMaterials");
		girl.renderer.material = materials.girlNeutral;

		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGuy = 	"Qu'est-ce qu'on fait?" + "\n" + 
								"";
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		
		// Example
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new D3_6()); 		// change dialogue
			break;
		
		}
		
	}
	
	public void Exit(){

		buttons.reset();

	}
}
