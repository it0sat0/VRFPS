using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public float CameraSpeed = 0.005f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0, 0, CameraSpeed);
	}
}
