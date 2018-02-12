using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPScript : MonoBehaviour {

	public PlayerController OVRPlayerController;
	public HPPanel HPPanel;
	
	// Update is called once per frame
	public void Update () {
		//HPパネル更新
		HPPanel.UpdateHP (OVRPlayerController.HP);

		//playerのHPが0でGameOver
		if (OVRPlayerController.HP <= 0) {
			Application.LoadLevel ("GameOver");
		}
	}
}
