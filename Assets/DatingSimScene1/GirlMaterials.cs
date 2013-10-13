using UnityEngine;
using System.Collections;

public class GirlMaterials : MonoBehaviour {
	/*
	 * Container class for the materials of the girls emotions
	 */
	public Material girlNeutral;
	public Material girlAngry;
	public Material girlSad;
	public Material girlHappy;
	public Material girlSurprised;
	
	public AudioSource audioStaceySurpris;
	public AudioSource audioStaceyNeutre;
	public AudioSource audioStaceyJoyeux;
	public AudioSource audioStaceyFache;
	
	void Start()
	{
		//Audio pour Stacey Surpris
		audioStaceySurpris = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClipStaceySurpris;
		myAudioClipStaceySurpris = (AudioClip)Resources.Load("stacey/Stacey_surpris");
		audioStaceySurpris.clip = myAudioClipStaceySurpris;	
		
		//Audio pour Stacey neutre
		audioStaceyNeutre = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClipStaceyNeutre;
		myAudioClipStaceyNeutre = (AudioClip)Resources.Load("stacey/Stacey_neutre");
		audioStaceyNeutre.clip = myAudioClipStaceyNeutre;	
		
		//Audio pour Stacey joyeux
		audioStaceyJoyeux = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClipStaceyJoyeux;
		myAudioClipStaceyJoyeux = (AudioClip)Resources.Load("stacey/Stacey_joyeux");
		audioStaceyJoyeux.clip = myAudioClipStaceyJoyeux;	
		
		//Audio pour Stacey faché
		audioStaceyFache = (AudioSource)gameObject.AddComponent("AudioSource");
		AudioClip myAudioClipStaceyFache;
		myAudioClipStaceyFache = (AudioClip)Resources.Load("stacey/Stacey_facher");
		audioStaceyFache.clip = myAudioClipStaceyFache;	
		
		//exemple utilisation:
		//audioStaceySurpris.PlayOneShot(audioStaceySurpris.clip);
		
	}
}
