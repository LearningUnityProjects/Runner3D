using UnityEngine;
using System.Collections;

public class droneScript : MonoBehaviour {
	private float yPosition;
	private CharacterController controller;
	private float initY;
	private Vector3 moveDirection;
	private bool subiendo;
	public int speed;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
		yPosition = controller.transform.position.y;
		initY = yPosition;
		moveDirection = new Vector3 (0, 1, 0);
		subiendo = true;
	}
	
	// Update is called once per frame
	void Update () {
		yPosition = controller.transform.position.y;
		if (subiendo) {
			if(yPosition >= initY + 2)	
				subiendo = false;
			else 
				moveDirection = new Vector3 (0, 1, 0);
		} else {
			if(yPosition <= initY-2)
				subiendo = true;
			else
				moveDirection = new Vector3 (0, -1, 0);
		}
		controller.Move (moveDirection * Time.deltaTime * speed);
	}
}
