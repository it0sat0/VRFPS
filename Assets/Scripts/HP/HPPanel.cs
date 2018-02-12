using UnityEngine;
using System.Collections;

public class HPPanel : MonoBehaviour {

	public GameObject[] icons;

	//HPに応じてスプライトを出しわける
	public void UpdateHP (int HP){
		for (int i = 0; i < icons.Length; i++){
			if (i < HP) icons[i].SetActive (true);
			else icons[i].SetActive(false);
		}
	}
}
