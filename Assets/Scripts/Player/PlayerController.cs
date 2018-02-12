using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public Camera camera;
	public AudioSource gunSound;
	public int HP;
	public int HeartHP;
	public GameObject Heart;


 


	// Use this for initialization
	void Start () {
        //カーソルロック
        Screen.lockCursor = true;
        // _EnemyScript = Teki.GetComponent<EnemyScript>();

        HP = 10;
        }
	
	// Update is called once per frame
	void Update () {
		//Bボタンを押したら
		if (Input. GetButtonDown("Fire2")) {
			Shot ();
			gunSound.Play ();
		}
	}
	
	void Shot (){
		//Rayを飛ばす距離
		int distance = 50;
		//スクリーン中心へRayを飛ばす
		Vector3 center = new Vector3 (Screen.width / 2, Screen.height / 2, 0);
		Ray ray = camera.ScreenPointToRay (center);
		RaycastHit hitInfo;

		//Rayが何かにぶつかったとき
		if (Physics.Raycast (ray, out hitInfo, distance)) {
			//ぶつかったのがEnemyだったら
			if (hitInfo.collider.tag == "Enemy") {
				//その物体にDamageを実行させる
				hitInfo.collider.SendMessage ("Damage");
			}
		}

		//Rayが何かにぶつかった時
        if (Physics.Raycast(ray,out hitInfo,distance)){
            //ぶつかったのがHeartだったら
            if (hitInfo.collider.tag == "Heal") {
                //HeartDamageを実行
				hitInfo.collider.SendMessage("HeartDamage");
				Heal ();
                Debug.Log("Heal");
            }
        }

		//Rayが何かにぶつかった時
		if (Physics.Raycast(ray,out hitInfo,distance)){
			//ぶつかったのがItemだったら
			if (hitInfo.collider.tag == "Item") {
				//ItemDamageを実行
				hitInfo.collider.SendMessage("ItemDamage");
				Debug.Log("Item");
			}
		}
			
	}

    public void PlayerDamage () {
	     //敵からダメージを受けたときHPを1減らす
	     HP -- ; //HPを1減らす
        Debug.Log(HP + "Damage");
	}

    public void PlayerHeal()
    {
        //HPが１回復する
        HP += 1; //HPを1増やす
        Debug.Log(HP + "Heal");
    }

	public void Heal() {
		HP += 1;
		}	
}
