using UnityEngine;
using System.Collections;

public class BtnsScript : MonoBehaviour {

	// Use this for initialization
	
	public GameObject BallPrefab;
	public GameObject BflyPrefab;
	public GameObject BflyPrefab2;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.O))
		{
			
		}
		else if(Input.GetKeyDown(KeyCode.K))
		{
		}
		else if(Input.GetKeyDown(KeyCode.M))
		{
			if(BflyPrefab != null)
			{
				float r = 0f;
				r = Mathf.Ceil((float)Random.Range(-4,4));
				Instantiate(BflyPrefab,new Vector3(r,0f,-2f),Quaternion.identity);
			}
			
			if(BflyPrefab2 != null)
			{
				float r = 0f;
				r = Mathf.Ceil((float)Random.Range(-4,4));
				Instantiate(BflyPrefab2,new Vector3(r,1f,-2f),Quaternion.identity);
			}
				
			
		}
		else if(Input.GetKeyDown(KeyCode.I))
		{
			if(BallPrefab != null)
			{
				float r = 0f;
				r = Mathf.Ceil((float)Random.Range(-4,4));
				Instantiate(BallPrefab,new Vector3(r,4f,-2f),Quaternion.identity);
			}
		}
		else if(Input.GetKeyDown(KeyCode.J))
		{
		}
	}
}
