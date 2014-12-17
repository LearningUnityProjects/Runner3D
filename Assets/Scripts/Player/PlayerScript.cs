using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	public GameObject retryDialog;
	public GameObject highScoreDialog;
	public GameObject panel;
	public float maxTime = 5.0f;

	public bool god { get; set;}

	private float godTime = 0.0f;
	private GameObject godParticles;

	public bool NewHighScore() {
		bool ret = false;
		Text scoreText = GameObject.Find("/UI/Canvas/Panel/Score").GetComponent<Text>();
		int score = int.Parse(scoreText.text);
		int score5 = PlayerPrefs.GetInt("Player Score 5");
		Debug.Log("score: " + score5  + " < " + score);
		if (score > score5) {
			ret = true;
		}
		return ret;
	}

	public void Die() {
		panel.SetActive (true);
		if (NewHighScore()) highScoreDialog.SetActive(true);
		else retryDialog.SetActive(true);
	}
	

	// Use this for initialization
	void Start () {
		god = false;
		godParticles = transform.FindChild ("god").gameObject;
		panel.SetActive (false);
		retryDialog.SetActive(false);
		highScoreDialog.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Keypad2)) {
			god = true;
		} 
		if (god) {
			if (godTime == 0.0f) {
				transform.GetComponent<MovementScript> ().stopSprint = false;
				transform.GetComponent<MovementScript> ().startSprint = true;
			} else {
				transform.GetComponent<MovementScript> ().startSprint = false;
			}
						Debug.Log ("I'm on god mode");
						godTime += Time.deltaTime;
						if (godTime >= maxTime && !(Input.GetKeyDown (KeyCode.Keypad2))) {
								transform.GetComponent<MovementScript> ().stopSprint = true;
								transform.GetComponent<MovementScript> ().startSprint = false;
								godTime = 0.0f;
								god = false;
								Debug.Log ("Now I'm a simple mortal");
						} else {
							transform.GetComponent<MovementScript> ().stopSprint = false;
						}
				} else {
			Debug.Log ("Now I'm a simple mortal");		
		}
		godParticles.SetActive (god);
	}
}
