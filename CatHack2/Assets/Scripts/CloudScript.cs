using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CloudScript : MonoBehaviour {
	
	public GameObject biscPrefab1;
	private LinkedList<UnityEngine.Object> ListOfBisc1;
	// Use this for initialization
	void Start () {
		//GameObject friskies =  GameObject.FindGameObjectWithTag("Respawn");
		//Instantiate(ranaPre,new Vector3(transform.position.x,transform.position.y-0.5f,transform.position.z),Quaternion.identity);
		ListOfBisc1 = new LinkedList<UnityEngine.Object>() ;
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
		{
			InstanciateDrops(2);
			//KillBiscuit();
		}
		
		if(Input.GetKeyDown(KeyCode.N))
		{
			kill(); 
			Debug.Log(Application.levelCount);
			
		}
	}
	
	IEnumerator KillBiscuit()
	{
		yield return new WaitForSeconds(5);
		kill();
	}
	
	 void kill()
	{
		if(ListOfBisc1.Count > 0)
		{
			var del = (UnityEngine.Object)ListOfBisc1.Last.Value;
			Destroy(del);
			ListOfBisc1.RemoveLast();
		}
	}
	
	void InstanciateDrops(int count)
	{
		int r = Random.Range(2,4);
		float diff = 2 / r;
		for(int i =0; i<count;i++)
			ListOfBisc1.AddFirst(Instantiate(biscPrefab1,new Vector3(transform.position.x,transform.position.y-diff,transform.position.z),Quaternion.identity));
	}
}
