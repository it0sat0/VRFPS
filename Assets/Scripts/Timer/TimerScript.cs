using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
	float timer = 120f;
	public Text timerlabel;
	public static int Timer = 120;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//カウントダウンさせる
		timer -= Time.deltaTime;
		timerlabel.text =  string.Format("{0:f1}", timer)/*小数点１の位まで表示する*/ + "s";

		if (timer <= 0) {
			Application.LoadLevel ("finish");
		}
	}
}
