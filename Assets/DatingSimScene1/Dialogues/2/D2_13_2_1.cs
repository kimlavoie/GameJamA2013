﻿using UnityEngine;
using System.Collections;

public class D2_13_2_1 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		GameObject girl = GameObject.Find("Girl");
		GirlMaterials materials = (GirlMaterials) girl.GetComponent("GirlMaterials");
		girl.renderer.material = materials.girlAngry;
		AudioSource audio = materials.audioStaceyFache;
		audio.PlayOneShot(audio.clip);
		// get the button manager, then change the text of the buttons to make them appear. button{ID} send the message ID when clicked
		
		// Example
		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGirl = 	"QUOI? Après tout ce que tu m'as fait endurer!" + "\n" + 
								"";
		
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new D2_13_2_2()); 		// change dialogue
			break;
		
		}
		
	}
	
	public void Exit(){
		
		buttons.reset();
		
	}
}
