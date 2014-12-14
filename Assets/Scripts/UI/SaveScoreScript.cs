using UnityEngine;
using System.Collections;

public class SaveScoreScript : MonoBehaviour {

	void UpdateHighScore(int max, int score1, int score2, int score3, int score4) {
		if (max < 5) {
			PlayerPrefs.SetString("Player Name 5", PlayerPrefs.GetString("Player Name 4"));
			PlayerPrefs.SetInt("Player Score 5", score4);
		}
		if (max < 4) {
			PlayerPrefs.SetString("Player Name 4", PlayerPrefs.GetString("Player Name 3"));
			PlayerPrefs.SetInt("Player Score 4", score3);
		}
		if (max < 3) {
			PlayerPrefs.SetString("Player Name 3", PlayerPrefs.GetString("Player Name 2"));
			PlayerPrefs.SetInt("Player Score 3", score2);
		}
		if (max < 2) {
			PlayerPrefs.SetString("Player Name 2", PlayerPrefs.GetString("Player Name 1"));
			PlayerPrefs.SetInt("Player Score 2", score1);
		}
	}
	
	public void UpdateHighScore(int score, string name) {
		Debug.Log("new Score " + name + " " + score);
		int score1 = PlayerPrefs.GetInt("Player Score 1");
		int score2 = PlayerPrefs.GetInt("Player Score 2");
		int score3 = PlayerPrefs.GetInt("Player Score 3");
		int score4 = PlayerPrefs.GetInt("Player Score 4");
		int score5 = PlayerPrefs.GetInt("Player Score 5");
		if (score > score1) {
			UpdateHighScore(1, score1, score2, score3, score4);
			PlayerPrefs.SetString("Player Name 1", name);
			PlayerPrefs.SetInt("Player Score 1", score);
		} else if (score > score2) {
			UpdateHighScore(2,score1, score2, score3, score4);
			PlayerPrefs.SetString("Player Name 2", name);
			PlayerPrefs.SetInt("Player Score 2", score);
		} else if (score > score3) {
			UpdateHighScore(3,score1, score2, score3, score4);
			PlayerPrefs.SetString("Player Name 3", name);
			PlayerPrefs.SetInt("Player Score 3", score);
		} else if (score > score4) {
			UpdateHighScore(4,score1, score2, score3, score4);
			PlayerPrefs.SetString("Player Name 4", name);
			PlayerPrefs.SetInt("Player Score 4", score);
		} else if (score > score5) {
			PlayerPrefs.SetString("Player Name 5", name);
			PlayerPrefs.SetInt("Player Score 5", score);
		}
		PlayerPrefs.Save ();
	}
}
