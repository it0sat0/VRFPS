using UnityEngine;
using System.Collections;

public class RetryScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire3")){
 			Application.LoadLevel("Title");
            ScoreScript.score = 0;
		}
       
	}
}
