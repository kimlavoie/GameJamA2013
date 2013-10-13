﻿using UnityEngine;
using System.Collections;

public class D4_6 : Dialogue{

	GUIButtonsScript buttons;		// access to the button manager
	
	public void Enter(){
		
		GameObject girl = GameObject.Find("Girl");
		girl.renderer.enabled = true;
		GirlMaterials materials = (GirlMaterials) girl.GetComponent("GirlMaterials");
		girl.renderer.material = materials.girlSurprised;
		AudioSource audio = materials.audioStaceySurpris;
		audio.PlayOneShot(audio.clip);
		
		
		buttons = (GUIButtonsScript) GameObject.Find ("GUIButtons").GetComponent("GUIButtonsScript");
		//						"012345678901234567890123456789012345678901234567890123456" <- Max length (57 char)
		buttons.buttonGirl = 	"Tu as encore beaucoup de temps libre ces temps-ci, Chad?" + "\n" + 
								"";
	}
	
	public void Execute(int choice){
		// choice is the ID of the button clicked. 0 is the space bar, but could be a click on GUIText (TODO)
		switch(choice){
		case 0:
			DialogueManager.getDialogueManager().changeDialogue(new D4_7()); 		// change dialogue
			break;
		}
		
	}
	
	public void Exit(){
		// resetting parameters, to make sure everything is ok in the next dialogue (no residuals)
		buttons.reset();
	}

}
