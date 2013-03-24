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
		if(transform.position.x > 4)
		{
			movDirectionRight = false;
		}
		
		if(transform.position.x < -5)
		{
			movDirectionRight = true;
		}
		
		if(movDirectionRight)
		{
			//transform.position = new Vector3(transform.position.x+Xmov,transform.position.y,transform.position.z);
			iTween.MoveTo(gameObject,iTween.Hash("x",4.1,"time",15,"easetype","linear"));
		}
		else
		{
			//transform.position = new Vector3(transform.position.x-Xmov,transform.position.y,transform.position.z);
			iTween.MoveTo(gameObject,iTween.Hash("x",-6.1,"time",15,"easetype","linear"));
		}
		
		if(Input.GetKeyDown(KeyCode.B))
		{
			InstanciateDrops(3);
			//KillBiscuit();
		}
		
		if(Input.GetKeyDown(KeyCode.N))
		{
			kill(); 
			//Debug.Log(Application.levelCount);
			
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
		int min = 0-count/2;
		int max = 0+count/2;
		int r = 0;
		//Debug.Log(r);
		//float diff = 3 / r;
		int xDiff = -1;
		for(int i =0; i<count;i++)
		{
			r = Random.Range(min,max);
			ListOfBisc1.AddFirst(Instantiate(biscPrefab1,new Vector3(transform.position.x+min+i,transform.position.y+r,transform.position.z),Quaternion.identity));
		}
	}
}
