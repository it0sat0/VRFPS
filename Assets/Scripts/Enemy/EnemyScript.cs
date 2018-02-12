using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;
	public int point = 50;
	public int enemyHP = 2;
    public GameObject blood;
    public GameObject P;

    // Use this for initialization
    void Start()
    {
        //生成されたときにOVRPlayerControllerを探してtargetに代入
        GameObject player = GameObject.Find("OVRPlayerController");
        target = player.transform;
        agent = GetComponent<NavMeshAgent>();
        Destroy(gameObject, 500);
    }
       
	
	// Update is called once per frame
	void Update () {
		//playerを追いかける
		agent.SetDestination (target.position);
	}


    //ダメージを受けたときの処理
    public void Damage()
    {
        enemyHP -= 1; //HPを1減らす
		GameObject clone = Instantiate(blood, transform.position + new Vector3(0, 1, 0), transform.rotation) as GameObject;
		Destroy(clone.gameObject, 5.0f);//bloodを消去

        if (enemyHP == 0)
        {
            //HPが0になったら
            ScoreScript.score += point;
			Debug.Log ("Damageokok");
			Destroy(this.gameObject);//敵を削除
        }
    }


	//プレイヤーがダメージを受けるとき
	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "OVRPlayerController") {
			other.gameObject.SendMessage ("PlayerDamage");
			Destroy (this.gameObject); //敵を削除
           
        }
	}
}

