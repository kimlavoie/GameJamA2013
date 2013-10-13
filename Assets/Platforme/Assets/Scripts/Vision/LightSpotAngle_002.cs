using UnityEngine;
using System.Collections;

public class LightSpotAngle_002 : MonoBehaviour
{
	public float diminish;

	
	void Update()
	{
		int relation = GererVariablesGlobales.getGererVariablesGlobales().relation;
		light.spotAngle -= diminish * Time.deltaTime * (((relation/4)/172) + 0.5f); 	
		
		if(light.spotAngle == 1)
		{
			Application.LoadLevel("GameOverScene");
		}
	}
}
