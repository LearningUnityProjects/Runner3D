using UnityEngine;
using System.Collections;

public class spiderController : MonoBehaviour {
	public float initSpeed = 6.0f;
	public float jumpSpeed = 18.0F;
	public float gravity = 20.0F;
	private bool right = true;
	
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
		controller.animation.CrossFade ("Run");
		lane = -1;
		speed = initSpeed;
		isCrouching = false;
		isSprinting = false;
	}
	
	
	void OnControllerColliderHit(ControllerColliderHit hit) {
		CharacterController controller = GetComponent<CharacterController>();
		if (hit.gameObject.name == "WALL") {
			controller.transform.Rotate(new Vector3(0,180,0));
			right = !right;
		}
	}
	
	
	
	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		
		controller.animation.CrossFade ("Run");
		if(right)moveDirection = new Vector3(1, 0,0);
		else moveDirection = new Vector3(-1, 0,0);
		controller.Move(moveDirection * Time.deltaTime * speed);
		//controller.transform.rigidbody.AddForce(transform.forward * speed * Time.deltaTime, ForceMode.Acceleration);
	}
	
	
}