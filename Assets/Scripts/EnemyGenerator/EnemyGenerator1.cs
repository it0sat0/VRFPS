using UnityEngine;
using System.Collections;

public class EnemyGenerator1 : MonoBehaviour {

	public GameObject enemy;
	float timer = 0;
	int interval = 10;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    timer += Time.deltaTime;
		if (timer >= interval) {
			//ランダムに敵を出現させる
			transform.position = new Vector3 (Random.Range (0, -500), 0, Random.Range (0, -800));
			timer = 0;
			Instantiate (enemy, transform.position, transform.rotation);
		}
	}
}
