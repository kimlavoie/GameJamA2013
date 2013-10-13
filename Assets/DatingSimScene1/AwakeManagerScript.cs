using UnityEngine;
using System.Collections;

public class AwakeManagerScript : MonoBehaviour {	
	// Use this for initialization
	void Start () {
		DialogueManager.getDialogueManager();		// awake manager and set first dialogue
	}
	
	// Update is called once per frame
	void Update () {
		// set the key to go forward in dialogues
		if(Input.GetKeyDown(KeyCode.Return)){;
			DialogueManager.getDialogueManager().sendMessage(0);	
		}
	}
}
