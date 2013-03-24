using UnityEngine;
using System.Collections;

public class BtnsScript : MonoBehaviour {

	// Use this for initialization
	
	public GameObject BallPrefab;
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
		}
		else if(Input.GetKeyDown(KeyCode.I))
		{
			if(BallPrefab != null)
			{
				float r = 0f;
				r = Mathf.Ceil((float)Random.Range(-4,4));
				Instantiate(BallPrefab,new Vector3(r,7f,0f),Quaternion.identity);
			}
		}
		else if(Input.GetKeyDown(KeyCode.J))
		{
		}
	}
}
