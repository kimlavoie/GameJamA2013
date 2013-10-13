using UnityEngine;
using System.Collections;

public class animation : MonoBehaviour {
	
	public float FPS;
	private float secondsToWait;
	public Texture[] framesChadWalk;
	public Texture[] framesChadBackWalk;
	public Texture[] framesChadJump;
	private bool Loop;

	
	
	private string animationState;
	private int currentFrame;
	
	// Use this for initialization
	void Start ()
	{
		currentFrame = 0;
		secondsToWait = 1/FPS;
		StartCoroutine(Animate());
	}
	
	IEnumerator Animate()
	{
		bool stop = false;
		
		if(Loop == false)
			stop = true;

		if(currentFrame >= framesChadWalk.Length && animationState == "chadWalk")
			currentFrame = 0;
		if(currentFrame >= framesChadBackWalk.Length && animationState == "chadBackWalk")
			currentFrame = 0;

		yield return new WaitForSeconds(secondsToWait);
		
		switch (animationState)
		{
		case "chadWalk": 
			renderer.material.mainTexture = framesChadWalk[currentFrame];
			break;
		case "chadJump":
			renderer.material.mainTexture = framesChadJump[0];
			break;
		case "chadBackWalk":
			Debug.Log("Ta mere");
			renderer.material.mainTexture = framesChadBackWalk[currentFrame];
			break;
		case "chadBackJump":
			renderer.material.mainTexture = framesChadJump[1];
			break;

		}

		currentFrame++; //Pour changer de texteure lors de la prochaine itération.
		
		if(stop == false)
			StartCoroutine(Animate());

	}
	
	void Update () 
	{

		
		if(Input.GetKeyDown(KeyCode.RightArrow))	//Appuie fleche droite
		{
			if(Input.GetKey(KeyCode.Space))
			{}
			else
				{
					animationState = "chadWalk";
					Loop = true;	
					StartCoroutine(Animate ());
				}
		}
		
		else if(Input.GetKeyUp(KeyCode.RightArrow))	//Relache fleche droite
		{
			Loop = false;	
			currentFrame = 0;
			StopCoroutine("Animate ()");
		}
		

		
		else if(Input.GetKeyDown(KeyCode.LeftArrow))//Appuie fleche gauche
		{
			if(Input.GetKey(KeyCode.Space))
			{}
			else
				{
					animationState = "chadBackWalk";
					Loop = true;	
					StartCoroutine(Animate ());
				}
		}
		
		else if(Input.GetKeyUp(KeyCode.LeftArrow))	//Relache fleche gauche
		{
			Loop = false;	
			currentFrame = 0;
			StopCoroutine("Animate ()");
		}
		
		else if(Input.GetKeyDown(KeyCode.Space) && animationState == "chadWalk")	//Appuie fleche haut (Jump avant)
		{
			animationState = "chadJump";
			Loop = true;	
			StartCoroutine(Animate ());
		}
		
		else if(Input.GetKeyDown(KeyCode.Space) && animationState == "chadBackWalk")	//Appuie fleche haut (Jump Arrere)
		{
			animationState = "chadBackJump";
			Loop = true;	
			StartCoroutine(Animate ());
		}
		
		else if(Input.GetKeyUp(KeyCode.Space))	//Relache fleche haut
		{
			if(Input.GetKey(KeyCode.RightArrow))
			{
				animationState = "chadWalk";
				Loop = true;	
				StopAllCoroutines();
				StartCoroutine(Animate ());
			}
			else if(Input.GetKey(KeyCode.LeftArrow))
			{
				animationState = "chadBackWalk";
				Loop = true;	
				StopAllCoroutines();
				StartCoroutine(Animate ());
			}
			else 
			{
				/*if(animationState == "chadJump")
					animationState = "chadWalk";
				else if(animationState == "chadBackJump")
					animationState = "chadBackWalk";
				else*/
					animationState = "chadWalk";
				
				Loop = false;	
				currentFrame = 0;
				StopAllCoroutines();
				renderer.material.mainTexture = framesChadWalk[currentFrame];
			}
		}
		
		
		


	}
}
