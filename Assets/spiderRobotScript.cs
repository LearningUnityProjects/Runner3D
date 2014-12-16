using UnityEngine;
using System.Collections;

public class spiderRobotScript : MonoBehaviour {
	private Vector3 moveDirection;
	public float speed;
	private CharacterController controller;

	// Use this for initialization
	void Start () {
		moveDirection = new Vector3 (0, 0, -1);
		speed = 1/2;
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		controller.animation.Play("walk");
		controller.Move (moveDirection * speed);
	}
}
