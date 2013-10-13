using UnityEngine;
using System.Collections;

public class GererVariablesGlobales 
{
	static public GererVariablesGlobales instance;
	public int money;
	public int relation;
	private PlayerMovement player;
	
	private GererVariablesGlobales()
	{
		money = 0;
		relation = 1;
	}
	
	static public GererVariablesGlobales getGererVariablesGlobales(){
		if(instance == null){
			instance = new GererVariablesGlobales();	
		}
		return instance;
	}
}
