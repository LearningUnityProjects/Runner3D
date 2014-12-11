using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour {

	public InputField name;

	public void StartGame()
	{
		Application.LoadLevel(1);
	}

	public void StopGame()
	{
		Application.Quit();
	}

	public void RestartGame()
	{
		Application.LoadLevel (Application.loadedLevelName);
	}
	
	public void ExitToMenu()
	{
		Application.LoadLevel (0);
	}

	public void SaveScore()
	{
		Text scoreText = GameObject.Find("/Canvas/Panel/Score").GetComponent<Text>();
		int score = int.Parse(scoreText.text);
		Debug.Log ("input field " + name.value); 
		gameObject.GetComponent<ScoreScript>().UpdateHighScore(score,name.value);
		Application.LoadLevel (0);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
