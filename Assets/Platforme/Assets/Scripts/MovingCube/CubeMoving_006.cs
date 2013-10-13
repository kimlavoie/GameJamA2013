using UnityEngine;
using System.Collections;

public class CubeMoving_006 : MonoBehaviour 
{
	public float smooth;
	public bool monter;
	
	Vector3 positionA = new Vector3(2f, 26f, 0f);
    Vector3 positionB = new Vector3(-7f, 16f, 0f);
	
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
			monter = false;
		}
		
		if(transform.position.x <= positionB.x)
		{
			monter = true;
		}
	}
		
	void ChangerPosition()
	{
		if(monter)
		{
		 	transform.Translate(Vector3.right * Time.deltaTime * 3);
		}
		
		if(!monter)
		{
			transform.Translate(Vector3.left * Time.deltaTime * 3);	
		}
			
	}
}

