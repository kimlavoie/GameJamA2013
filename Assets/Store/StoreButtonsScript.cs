using UnityEngine;
using System.Collections;

public class StoreButtonsScript : MonoBehaviour {
	
	private string description =	"";
	private string message = 		"";
	private string item1 = 			"Bonbons";
	private string item2 = 			"Chocolats";
	private string item3 = 			"Fleurs";
	private string item4 = 			"Bijoux";
	private string quitter = 		"Quitter";
	
	private float lastTimeDescription;
	private float lastTimeMessage;
	
	private void OnGUI(){
		/*********************Styles******************************/
		GUIStyle style = new GUIStyle(GUI.skin.GetStyle("Button"));
		style.fontSize = Screen.height/24;
		
		GUIStyle IPStyle = new GUIStyle(GUI.skin.GetStyle("Button"));
		IPStyle.fontSize = Screen.height/6;
		
		/*********************Messages****************************/
		if(!message.Equals("")){
			if(GUI.Button(new Rect(Screen.width/3 + 20,10,Screen.width-Screen.width/3 - 30, Screen.height/10), message, style)){
				message = "";
			}
		}
		
		if(!description.Equals("")){
			if(GUI.Button(new Rect(10,Screen.height-Screen.height/10-10,Screen.width-Screen.width/8 - 20,Screen.height/10), description, style)){
				description = "";
			}
		}
		string IP = "IP: " + GererVariablesGlobales.getGererVariablesGlobales().money;
		
		if(GUI.Button (new Rect(Screen.width/3 + 20 , Screen.height/10 + 20, Screen.width - Screen.width/3 - 30, Screen.height - Screen.height/5 - 40), new GUIContent(IP,IP), IPStyle)){	
		}
		
		/*********************Items on click**********************/
		// Bonbons
		if(GUI.Button(new Rect(10,10 ,Screen.width/3,Screen.height/10), new GUIContent(item1, item1), style)){
			buy ("bonbons", 20, 20);
		}
		// Chocolats
		if(GUI.Button(new Rect(10,Screen.height/2 - Screen.height/4 + 10,Screen.width/3,Screen.height/10), new GUIContent(item2, item2), style)){
			buy ("chocolats",40, 40);
		}
		// Fleurs
		if(GUI.Button(new Rect(10,Screen.height/2 + 10,Screen.width/3,Screen.height/10), new GUIContent(item3, item3), style)){
			buy ("fleurs", 60, 60);
		}
		// Bijoux
		if(GUI.Button(new Rect(10,Screen.height/2 + Screen.height/4 + 10,Screen.width/3,Screen.height/10), new GUIContent(item4, item4), style)){
			buy ("bijoux", 100, 100);
		}		
		// Quitter
		if(GUI.Button (new Rect(Screen.width - Screen.width/8, Screen.height - Screen.height/10 - 10, Screen.width/8 - 10, Screen.height/10), new GUIContent(quitter, quitter), style)){
			Application.LoadLevel("DatingSimScene1");
		}
		
		/**********************Descriptions*************************/
		string hover = GUI.tooltip;
		

		if(hover == item1){
			describe ("Bonbons", 20, "un peu");
		}
		else if(hover == item2){
			describe("Chocolats", 40, "");
		}
		else if(hover == item3){
			describe("Fleurs", 60, "beaucoup");
		}
		else if(hover == item4){
			describe("Bijoux", 100, "énormément");
		}
		else if(hover == IP){
			description = "Les Infinity Points que vous avez accumulés";
			lastTimeDescription = Time.realtimeSinceStartup;
		}
		else if(hover == quitter){
			description = "Pour quitter le magasin et continuer l'aventure";
			lastTimeDescription = Time.realtimeSinceStartup;
		}
		else if(Time.realtimeSinceStartup - lastTimeDescription > 0.05){
			description = "";	
		}
		
		// Timer pour messages
		if(Time.realtimeSinceStartup - lastTimeMessage >= 2){
			message = "";	
		}
	}
	
	void buy(string name, int price, int relationPoints){
		/*
		 * Vérifie qu'on a assez d'argent, achete le produit si c'est le cas, et affiche un message
		 * Reset aussi le timer pour les messages
		 */ 
		if(GererVariablesGlobales.getGererVariablesGlobales().money - price >= 0){
			GererVariablesGlobales.getGererVariablesGlobales().money -= price;
			GererVariablesGlobales.getGererVariablesGlobales().relation += relationPoints;
			message = "Vous avez acheté des " + name + "!";
		}
		else {
			message = "Vous n'avez pas assez d'Infinity Points...";
		}
		lastTimeMessage = Time.realtimeSinceStartup;
	}
	
	void describe(string name, int price, string modifier){
		/*
		 * Décrit le produit et reset le timer pour les descriptions
		 */
		description = 	"* " + name + " *" + "\n" + 
						price + " IP - Améliore " + modifier + " la relation avec Stacey";
		lastTimeDescription = Time.realtimeSinceStartup;
	}
}
