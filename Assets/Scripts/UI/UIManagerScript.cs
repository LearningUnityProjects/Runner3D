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
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
