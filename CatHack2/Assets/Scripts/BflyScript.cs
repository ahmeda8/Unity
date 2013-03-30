using UnityEngine;
using System.Collections;

public class BflyScript : MonoBehaviour {
	
	private int timeout  = 0;
	// Use this for initialization
	void Start () {
		audio.Play();
		
	}
	
	// Update is called once per frame
	void Update () {
	 	Debug.Log("b1 update:"+timeout);
		if(timeout%300 == 0 )
		{
			int x = (int) Mathf.Ceil(Random.Range(-5,5));
			int y = (int) Mathf.Ceil(Random.Range(-1,+5));
			
			iTween.MoveTo(gameObject,iTween.Hash("x",x, "y",y,"easeType","linear","time",5));
		}
		timeout++;
	}
}
