using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public PlayerController player;
	public Text Scorelabel;
    public static int score = 0;
    

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//スコアの更新
		Scorelabel.text = "Score : " + score + "p";
	
		//ハイスコアを表示
		if (PlayerPrefs.GetInt ("HighScore") < score) {
			PlayerPrefs.SetInt ("HighScore", score);
		}
	}
}
