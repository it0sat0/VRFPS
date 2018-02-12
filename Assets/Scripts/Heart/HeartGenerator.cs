using UnityEngine;
using System.Collections;

public class HeartGenerator : MonoBehaviour {
	public GameObject Heart;

	// Use this for initialization
	void Start () {
		for (int HeartCount = 0; HeartCount <= 4; HeartCount++) {
			transform.position = new Vector3 (Random.Range (0, -1000), 7, Random.Range (0, -800));
			Instantiate (Heart, transform.position, transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
			
	}
}
