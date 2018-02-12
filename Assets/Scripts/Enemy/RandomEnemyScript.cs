using UnityEngine;
using System.Collections;

public class RandomEnemyScript : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;
	public int point = 50;
	public int enemyHP = 2;
	public int enemySpeed = 10;
	public GameObject blood;
	
	// Use this for initialization
	void Start () {
		//生成されたときにCubeを探してtargetに代入
		GameObject player = GameObject.Find ("Cube");
		target = player.transform;
		agent = GetComponent<NavMeshAgent> ();
		Destroy (gameObject, 500);
	}
	
	// Update is called once per frame
	void Update () {
		//cubeを追いかける
		agent.SetDestination (target.position);
	}
	
	//ダメージを受けたときの処理
	void Damage(){
		enemyHP -= 1; //HPを1減らす
		GameObject clone = Instantiate(blood, transform.position + new Vector3(0, 1, 0), transform.rotation) as GameObject;
		Destroy(clone.gameObject, 5.0f);//bloodを消去

		if (enemyHP == 0) {
			//HPが0になったら
			ScoreScript.score += point;
			Destroy (this.gameObject);//敵を削除
		}
	}
	
	//プレイヤーがダメージを受けるとき
	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "FPSController") {
			other.gameObject.SendMessage ("PlayerDamage");
			Destroy (this.gameObject); //敵を削除
		}
	}
}

