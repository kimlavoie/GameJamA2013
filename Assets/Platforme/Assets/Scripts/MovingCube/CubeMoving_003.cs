using UnityEngine;
using System.Collections;

public class CubeMoving_003 : MonoBehaviour
{
	public float smooth;
	public bool monter;
	
	Vector3 positionA = new Vector3(21f, 9f, 0f);
    Vector3 positionB = new Vector3(16f, 0.5f, 0f);
	
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
			transform.Translate(Vector3.left * Time.deltaTime * 2);	
		}
			
	}
}
