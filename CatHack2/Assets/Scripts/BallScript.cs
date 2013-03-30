using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
		{
			//Debug.Log("A pressed");
			rigidbody.AddForce(new Vector3(-100f,20f,0));
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			//Debug.Log("D pressed");
			rigidbody.AddForce(new Vector3(100f,20f,0));
		}
		if(Input.GetKeyDown(KeyCode.W))
		{
			rigidbody.AddForce(new Vector3(0f,320f,0));
		}
		
		if(transform.position.x > 9 || transform.position.x < -9) //if the ball goes out of creen delete it
			GameObject.Destroy(gameObject);
	}
}
