using UnityEngine;
using System.Collections;

public class CloudScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	private float Xmov =0.01f;
	private bool movDirectionRight = true;
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x > 5)
		{
			movDirectionRight = false;
		}
		
		if(transform.position.x < -5)
		{
			movDirectionRight = true;
		}
		
		if(movDirectionRight)
		{
			transform.position = new Vector3(transform.position.x+Xmov,transform.position.y,transform.position.z);
		}
		else
		{
			transform.position = new Vector3(transform.position.x-Xmov,transform.position.y,transform.position.z);
		}
	}
}
