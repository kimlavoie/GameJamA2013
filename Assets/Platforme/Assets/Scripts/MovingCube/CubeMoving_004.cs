using UnityEngine;
using System.Collections;

public class CubeMoving_004 : MonoBehaviour
{
	public float smooth;
	public bool monter;
	
	Vector3 positionA = new Vector3(5f, 27f, 0f);
    Vector3 positionB = new Vector3(5f, 18f, 0f);
	
	private Vector3 newPosition;
	
	void Update()
	{
		ChangerBool ();
		ChangerPosition();
	}
	
	void ChangerBool()
	{	
		if(transform.position.y >= positionA.y)
		{
			monter = false;
		}
		
		if(transform.position.y <= positionB.y)
		{
			monter = true;
		}
	}
		
	void ChangerPosition()
	{
		if(monter)
		{
		 	transform.Translate(Vector3.up * Time.deltaTime * 3);
		}
		
		if(!monter)
		{
			transform.Translate(Vector3.down * Time.deltaTime * 3);	
		}
			
	}
}
