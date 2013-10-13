using UnityEngine;
using System.Collections;

public class DoucheMouvement : MonoBehaviour 
{
	public bool droite;
	public float smooth = 3f;
	
	private Vector3 positionA = new Vector3(6f, 10f, 0f);
   	private Vector3 positionB = new Vector3(-1f, 10f, 0f);
	
	
	private Vector3 newPosition;
	
	public Texture[] framesDoucheWalk;
	public Texture[] framesDoucheBackWalk;
	
	public float FPS;
	private float secondsToWait;

	
	private int currentFrame;
	
		void Start ()
	{
		currentFrame = 0;
		secondsToWait = 1/FPS;
		StartCoroutine(Animate());

		droite = false;
	}
	
	
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
		if(!droite)
		{
		 	transform.Translate(Vector3.right * Time.deltaTime * smooth);
		}
		
		if(droite)
		{
			transform.Translate(Vector3.left * Time.deltaTime * smooth);	
		}
			
	}
	
	IEnumerator Animate()
	{
		
		if(currentFrame >= framesDoucheWalk.Length && droite)
			currentFrame = 0;
		if(currentFrame >= framesDoucheBackWalk.Length && !droite)
			currentFrame = 0;
		
		yield return new WaitForSeconds(secondsToWait);
		
		switch (droite)
		{
		case true: 
			Debug.Log(currentFrame.ToString());
			renderer.material.mainTexture = framesDoucheBackWalk[currentFrame];
			break;
		case false:
			
			Debug.Log(currentFrame.ToString());
			renderer.material.mainTexture = framesDoucheWalk[currentFrame];
			break;
		}
				
		currentFrame++;
		
		StartCoroutine(Animate());
		
		
	}
	
	
}
