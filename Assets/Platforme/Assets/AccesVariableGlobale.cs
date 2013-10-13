using UnityEngine;
using System.Collections;

public class AccesVariableGlobale : MonoBehaviour 
{
	public GUIText text;
	
	private GererVariablesGlobales variablesGlobales;
	
	void Start()
	{
		variablesGlobales = GererVariablesGlobales.getGererVariablesGlobales();
		text.text = "Money: " + variablesGlobales.money.ToString();
	}
	
	void Update()
	{
		text.text = "Money: " + variablesGlobales.money.ToString(); 	
	}
}
