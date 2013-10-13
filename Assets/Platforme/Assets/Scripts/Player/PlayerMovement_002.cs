using UnityEngine;
using System.Collections;

public class PlayerMovement_002 : MonoBehaviour
{
	public float speed;
	public float resetSpotAngle = 179f;
	public float smooth;
	public GUIText text1;
	public GUIText text2;
	public int countDrink;
	
	private DoucheMovement_002 doucheDirection;
	private GererVariablesGlobales variablesGlobales;	
	private bool jumping = false;
	private LightSpotAngle_002 lightSpot;
	
	
	public AudioSource audioCoins;
	public AudioSource audioDrink;
	public AudioSource audioDouchebag;
	public AudioSource audioJump;
	
	void Start()
	{
		countDrink = 0;
		doucheDirection = (DoucheMovement_002)GameObject.Find ("DoucheBag_002").GetComponent("DoucheMovement_002");
		variablesGlobales = GererVariablesGlobales.getGererVariablesGlobales();
		text1.text = "IP: " + variablesGlobales.money.ToString();
		text2.text = "Relation: " + variablesGlobales.relation.ToString();
		lightSpot = (LightSpotAngle_002)GameObject.Find("Spotlight_002").GetComponent("LightSpotAngle_002");
	
		//Audio pour Coins
		audioCoins = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClipCoins;
		if(myAudioClipCoins = (AudioClip)Resources.Load("others/Chad_Coins_Pickup_Sound"))
		audioCoins.clip = myAudioClipCoins;	
		audioCoins.volume = 1;
		
		//Audio pour drinks
		audioDrink = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClipDrink;
		myAudioClipDrink = (AudioClip)Resources.Load("others/Chad_Drinks_Pickup_Sound");
		audioDrink.clip = myAudioClipDrink;
		
		//Audio pour collisions douchebag
		
		audioDouchebag = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClipDouchebag;
		myAudioClipDouchebag = (AudioClip)Resources.Load("others/Douchebag_Collision_Sound");
		audioDouchebag.clip = myAudioClipDouchebag;
		
		//Audio pour collisions Jump
		audioJump = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClipJump;
		myAudioClipJump = (AudioClip)Resources.Load("others/Chad_Jump_Sound");
		audioJump.clip = myAudioClipJump;
	
	}
	
	void Update()
	{
		text1.text = "IP: " + variablesGlobales.money.ToString();
		
		if(countDrink == 3) 
		{
			Application.LoadLevel("store");	
		}
	}
	void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3(1f, 0f, 0f) * speed * Time.deltaTime;	
		}
		
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position -= new Vector3(1f, 0f, 0f) * speed * Time.deltaTime;	
		}
		
		if(Input.GetKeyDown(KeyCode.Space) && jumping == false)
		{
			jumping = true;
			rigidbody.AddForce(new Vector3(0f, 5f, 0f),ForceMode.Impulse);	
			audioJump.PlayOneShot(audioJump.clip);
		}
		
		else if(rigidbody.velocity.y <= 0.05 && rigidbody.velocity.y >= -0.05)
		{
			jumping = false;
		}
		
		if(transform.position.y <= -10)
		{ 
			Application.LoadLevel("GameOverScene"); 
		}
		
	}

	void OnCollisionStay(Collision other)
	{
		if (other.gameObject.tag == "CubeRight") 
		{ 
			transform.parent = other.transform;
		} 
	} 
	void OnCollisionExit(Collision other) 
	{ 
		if (other.gameObject.tag == "CubeRight")
		{ 
			transform.parent = null;
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "DoucheBag_002")
		{
			lightSpot.diminish += 5f;
			if(doucheDirection.droite)
			{
				rigidbody.AddForce(new Vector3(8f, 0f, 0f),ForceMode.Impulse);
			}
			else
			{
				rigidbody.AddForce(new Vector3(-8f, 0f, 0f),ForceMode.Impulse);
			}
			audioDouchebag.PlayOneShot(audioDouchebag.clip);
		}
		
		if(other.tag == "Drink_002")
		{
			countDrink += 1;
			other.gameObject.SetActive(false);
			lightSpot.light.spotAngle = resetSpotAngle;
			lightSpot.diminish = 5f;
			audioDrink.PlayOneShot(audioDrink.clip);
		}
		
		if(other.tag == "Coin_002")
		{
			variablesGlobales.money += 5;
			other.gameObject.SetActive(false);
			audioCoins.PlayOneShot(audioCoins.clip);
		}
	}
}
