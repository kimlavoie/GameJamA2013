using UnityEngine;
using System.Collections;

public class CubeMoving_005 : MonoBehaviour
{
	public float smooth;
	public bool monter;
	
	Vector3 positionA = new Vector3(8f, 10f, 0f);
    Vector3 positionB = new Vector3(8f, 19f, 0f);
	
	private Vector3 newPosition;
	
	void Update()
	{
		ChangerBool ();
		ChangerPosition();
	}
	
	void ChangerBool()
	{	
		if(transform.position.y <= positionA.y)
		{
			monter = true;
		}
		
		if(transform.position.y >= positionB.y)
		{
			monter = false;
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