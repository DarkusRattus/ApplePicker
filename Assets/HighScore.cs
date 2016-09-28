using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    static public int score = 1000;

	void Update () {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;
	}
}
