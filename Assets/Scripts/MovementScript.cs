﻿using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	public float initSpeed = 12.0f;
	public float jumpSpeed = 18.0F;
	public float gravity = 20.0F;

	private Vector3 moveDirection = Vector3.zero;
	private float speed;
	private float xPosition;
	private int lane;
	private bool isCrouching;
	private bool isJumping;
	private bool isSprinting;

	void Start(){
		CharacterController controller = GetComponent<CharacterController>();
		xPosition = controller.transform.position.x;
		controller.animation.CrossFade ("run");
		lane = 0;
		speed = initSpeed;
		isCrouching = false;
		isSprinting = false;
	}

	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		Vector3 pos = controller.transform.position;
		pos.x = Mathf.MoveTowards(pos.x, xPosition, 15.0F * Time.deltaTime);
		controller.transform.position = pos;

		if (!isJumping) {
			if (Input.GetKeyDown (KeyCode.LeftShift)) {
				speed = initSpeed * 2;
				isSprinting = true;
			}
			if (Input.GetKeyDown ("u") && lane != -1) {
					xPosition -= 3;
					controller.animation.Play ("strafeLeft");
					--lane;
			}
			if (Input.GetKeyUp ("u")) {
					controller.animation.CrossFade ("run");
			}
			if (Input.GetKeyDown ("i") && lane != 1) {
					xPosition += 3;
					controller.animation.Play ("strafeRight");
					++lane;
			}
			if(Input.GetKeyDown("j")){
				isCrouching = true;
			}	
			if(Input.GetKeyUp("j")){
				isCrouching = false;
			}
		}

		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			speed = initSpeed;	
			isSprinting = false;
		}

		if (Input.GetKeyDown (KeyCode.RightShift)) {
			speed = 0;
		}
		if (Input.GetKeyUp (KeyCode.RightShift)) {
			speed = initSpeed;
		}

		if (controller.isGrounded) {
			isJumping = false;
			if(isCrouching){
				if(isSprinting) controller.animation.CrossFade("crouchRun");
				else controller.animation.CrossFade("crouchWalk");
			}
			else if(isSprinting) controller.animation.CrossFade("sprint");
			else controller.animation.CrossFade("run");
			moveDirection = new Vector3(0, 0, 1);
			moveDirection = transform.TransformDirection(moveDirection);	
			moveDirection *= speed;
			if (Input.GetButton("Jump")){
				isJumping = true;
				moveDirection.y = jumpSpeed;
				controller.animation.CrossFade("jump");
			}
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
		//controller.transform.rigidbody.AddForce(transform.forward * speed * Time.deltaTime, ForceMode.Acceleration);
	}


}