using UnityEngine;
using System.Collections;

public class CloudScript : MonoBehaviour {
	
	public GameObject biscPrefab1;
	// Use this for initialization
	void Start () {
		//GameObject friskies =  GameObject.FindGameObjectWithTag("Respawn");
		//Instantiate(ranaPre,new Vector3(transform.position.x,transform.position.y-0.5f,transform.position.z),Quaternion.identity);
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
		
		if(Input.GetKeyDown(KeyCode.B))
			Instantiate(biscPrefab1,new Vector3(transform.position.x,transform.position.y-0.5f,transform.position.z),Quaternion.identity);
	}
}
