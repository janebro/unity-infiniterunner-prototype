using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {

	public float speed = 0.5f;
	

	void Update () 
	{
		Vector2 offset = new Vector2(Time.time * speed, 0);
		GetComponent<Renderer>().material.mainTextureOffset = offset;		
	}
}