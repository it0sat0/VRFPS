using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {
	
	public GameObject Cube;
	float timer = 0;
	int interval = 20;

	// Use this for initialization
	void Start () {
		//ランダムにCubeを出現させる
		transform.position = new Vector3 (Random.Range (0, -1000), 0, Random.Range (0, -800));
	}
	
	// Update is called once per frame
	void Update () {
		//Cubeを20秒ごとにランダムに場所移動させる
		timer += Time.deltaTime;
		if (timer >= interval) {
			transform.position = new Vector3 (Random.Range (0, -1000), 0, Random.Range (0, -800));
			timer = 0;
		}
	}
}
