using UnityEngine;
using System.Collections;

public class MainIntro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
		{
			audio.Play();
			iTween.MoveTo(gameObject,iTween.Hash("y",17,"easeType","easeInOutLog","time",4));
		}
		if(Input.GetKeyDown(KeyCode.Z))
		{
			Application.LoadLevel("level1");
		}
	}
}
