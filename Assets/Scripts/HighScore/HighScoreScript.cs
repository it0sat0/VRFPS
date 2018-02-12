using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoreScript: MonoBehaviour {

	public Text HighScoreLabel;

	// Use this for initialization
	void Start () {
		//ハイスコアを表示
		HighScoreLabel.text = "High Score : " + PlayerPrefs.GetInt ("HighScore") + "p";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
