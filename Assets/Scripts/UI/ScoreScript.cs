using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text highScore1;
	public Text highScore2;
	public Text highScore3;
	public Text highScore4;
	public Text highScore5;

	private void SetHighScore() {
		highScore1.text = "1. " + PlayerPrefs.GetString("Player Name 1") + " - " +  PlayerPrefs.GetInt("Player Score 1");
		highScore2.text = "2. " + PlayerPrefs.GetString("Player Name 2") + " - " +  PlayerPrefs.GetInt("Player Score 2");
		highScore3.text = "3. " + PlayerPrefs.GetString("Player Name 3") + " - " +  PlayerPrefs.GetInt("Player Score 3");
		highScore4.text = "4. " + PlayerPrefs.GetString("Player Name 4") + " - " +  PlayerPrefs.GetInt("Player Score 4");
		highScore5.text = "5. " + PlayerPrefs.GetString("Player Name 5") + " - " +  PlayerPrefs.GetInt("Player Score 5");
	}

	// Use this for initialization
	void Start () {
		if(highScore1) SetHighScore();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
