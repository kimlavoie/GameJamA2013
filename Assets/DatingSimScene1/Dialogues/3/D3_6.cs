using UnityEngine;
using System.Collections;

public class D3_6 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		GameObject girl = GameObject.Find("Girl");
		GirlMaterials materials = (GirlMaterials) girl.GetComponent("GirlMaterials");
		girl.renderer.material = materials.girlSurprised;
		AudioSource audio = materials.audioStaceySurpris;
		audio.PlayOneShot(audio.clip);

		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGirl = 	"Pourquoi tu me le demandes à moi, c'est toi qui devrait" + "\n" + 
								"me le dire, ce n'est pas à moi de toujours choisir!";
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		
		// Example
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new D3_7()); 		// change dialogue
			break;
		
		}
		
	}
	
	public void Exit(){

		buttons.reset();

	}
}
