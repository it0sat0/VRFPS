using UnityEngine;
using System.Collections;

public class HeartScript : MonoBehaviour {
	public GameObject Heart;
	public int HeartHP = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void HeartDamage(){
		HeartHP -= 1;
		if (HeartHP == 0) {
			
			Destroy (this.gameObject);
		}
	}
}
