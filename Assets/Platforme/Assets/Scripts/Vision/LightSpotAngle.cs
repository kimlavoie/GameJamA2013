using UnityEngine;
using System.Collections;

public class LightSpotAngle : MonoBehaviour 
{
	public float diminish;

	
	void Update()
	{
		int relation = GererVariablesGlobales.getGererVariablesGlobales().relation;
		light.spotAngle -= diminish * Time.deltaTime * (((relation/4)/21) + 0.5f); 	
		
		if(light.spotAngle == 1)
		{
			Application.LoadLevel("GameOverScene");
		}
	}
}
