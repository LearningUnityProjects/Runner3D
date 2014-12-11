using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CapsuleScript : MonoBehaviour {

	private Text scoreText;
	private int score;

	void OnTriggerEnter(Collider other) {
		Destroy(gameObject);
		++score;
		scoreText.text = score.ToString();
	}

	// Use this for initialization
	void Start () {
		scoreText = GameObject.Find("/Canvas/Panel/Score").GetComponent<Text>();
		Debug.Log("initial score: " + scoreText.text);
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, Time.deltaTime*200);
		score = int.Parse(scoreText.text);
	}
}
