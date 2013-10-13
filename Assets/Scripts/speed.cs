using UnityEngine;
using System.Collections;

public class speed : MonoBehaviour {
	public float vitesse;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			transform.position += new Vector3(Input.GetAxis("Horizontal"),0,0)*vitesse*Time.deltaTime;
			transform.position += new Vector3(0,Input.GetAxis("Vertical"),0)*vitesse*Time.deltaTime;
	
	
	}
}
