using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DiePlayerScript : MonoBehaviour {

	public GameObject retryDialog;
	public GameObject highScoreDialog;

	public bool NewHighScore() {
		bool ret = false;
		Text scoreText = GameObject.Find("/Canvas/Panel/Score").GetComponent<Text>();
		int score = int.Parse(scoreText.text);
		int score5 = PlayerPrefs.GetInt("Player Score 5");
		Debug.Log("score: " + score5  + " < " + score);
		if (score > score5) {
			ret = true;
		}
		return ret;
	}

	public void Die() {
		if (NewHighScore()) highScoreDialog.SetActive(true);
		else retryDialog.SetActive(true);
	}

	// Use this for initialization
	void Start () {
		retryDialog.SetActive(false);
		highScoreDialog.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
