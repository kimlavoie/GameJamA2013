using UnityEngine;
using System.Collections;

public class DialogueManager {
	static private int scene = 0;				// HACK ALERT !!!
	static private DialogueManager manager;
	private Dialogue currentDialogue;
	
	private DialogueManager(){		
		/*
		 * Set and enter first Dialogue
		 * Should not look like this ... but eh! Game Jam!
		 */
		switch(scene){
		case 0:
			currentDialogue = new D1_1();
			currentDialogue.Enter();
			scene++;
			break;
		case 1:
			currentDialogue = new D3_1();
			currentDialogue.Enter();
			scene++;
			break;
		case 2:
			currentDialogue = new D4_1();
			currentDialogue.Enter();
			scene++;
			break;
		}
		
	}
	
	static public DialogueManager getDialogueManager(){
		/*
		 * Part of the Singleton design pattern. Return the only instance of the manager.
		 * Create one if needed.
		 */
			
		if(manager == null){
			manager = new DialogueManager();
		}
			
		return manager;
	}
	
	public void changeDialogue(Dialogue newDialogue){
		/*
		 * Change the dialogue by exiting, then entering the new one
		 */
		currentDialogue.Exit();
		currentDialogue = newDialogue;
		currentDialogue.Enter();
	}
	
	public Dialogue getCurrentDialogue(){
		return currentDialogue;
	}
	
	public void sendMessage(int msg){
		/*
		 * Pass forward the message
		 */
		currentDialogue.Execute(msg);
	}
	
	public void destroy(){
		/*
		 * Break the design pattern, because of the scene change ... sorry
		 */
		manager = null;	
	}
}
