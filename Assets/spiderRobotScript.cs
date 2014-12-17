using UnityEngine;
using System.Collections;

public class spiderRobotScript : MonoBehaviour {
	private Vector3 moveDirection;
	public float speed;
	private CharacterController controller;

	// Use this for initialization
	void Start () {
		moveDirection = new Vector3 (0, 0, -1);
		speed = 7;
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		controller.Move (moveDirection * speed * Time.deltaTime);
	}
}
