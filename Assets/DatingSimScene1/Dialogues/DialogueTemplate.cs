using UnityEngine;
using System.Collections;

public class DialogueTemplate : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		/*
		// for enabling or disabling the girl, and change emotions
		GameObject girl = GameObject.Find("Girl");
		girl.renderer.enabled = true;
		GirlMaterials materials = (GirlMaterials) girl.GetComponent("GirlMaterials");
		girl.renderer.material = materials.girlNeutral;
		*/
		// get the button manager, then change the text of the buttons to make them appear. button{ID} send the message ID when clicked
		/*
		// Example
		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGirl = 	"" + "\n" + 
								"";
		//					"01234567890123456789" <- Max length (20 char)
		buttons.button1 = 	"yes";
		buttons.button2 = 	"no";
		buttons.button3 = 	"toaster";
		buttons.button4 = 	"...";
		*/
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		/*
		// Example
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new Intro3()); 		// change dialogue
			break;
		*/
		}
		
	}
	
	public void Exit(){
		// resetting parameters, to make sure everything is ok in the next dialogue (no residuals)
		/*
		buttons.reset();
		*/
	}
}
