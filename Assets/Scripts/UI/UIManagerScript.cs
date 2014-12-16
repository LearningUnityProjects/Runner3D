using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour {

	public InputField inputName;
	public GameObject retryPanel;
	public GameObject highScorePanel;

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
		Text scoreText = GameObject.Find("/UI/Canvas/Panel/Score").GetComponent<Text>();
		int score = int.Parse(scoreText.text);
		//Debug.Log ("input field " + inputName.value); 
		gameObject.GetComponent<SaveScoreScript> ().UpdateHighScore (score, "proba");//inputName.value);
		highScorePanel.SetActive(false);
		retryPanel.SetActive(true);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
