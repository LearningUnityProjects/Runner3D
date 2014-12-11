using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {

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
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
