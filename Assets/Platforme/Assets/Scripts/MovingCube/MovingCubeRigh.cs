using UnityEngine;
using System.Collections;

public class MovingCubeRigh : MonoBehaviour {
	public bool droite;
	
	Vector3 positionA = new Vector3(21f, 5f, 0f);
    Vector3 positionB = new Vector3(16f, 5f, 0f);
	
	private Vector3 newPosition;
	
	void Update()
	{
		ChangerBool ();
		ChangerPosition();
	}
	
	void ChangerBool()
	{	
		if(transform.position.x >= positionA.x)
		{
			droite = false;
		}
		
		if(transform.position.x <= positionB.x)
		{
			droite = true;
		}
	}
		
	void ChangerPosition()
	{
		if(droite)
		{
		 	transform.Translate(Vector3.right * Time.deltaTime * 3);
		}
		
		if(!droite)
		{
			transform.Translate(Vector3.left * Time.deltaTime * 2);	
		}
			
	}
}
