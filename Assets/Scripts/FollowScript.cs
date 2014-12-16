using UnityEngine;
using System.Collections;

public class FollowScript : MonoBehaviour {

	public GameObject player;
	
	private Vector3 moveDirection = Vector3.zero;
	private float speed;
	
	void Start(){
	}
	
	void Update() {
		speed = player.GetComponent<MovementScript>().speed;
		Debug.Log ("speed " + speed);
		CharacterController controller = GetComponent<CharacterController> ();
		moveDirection = new Vector3(0, 0, 1);
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		controller.Move(moveDirection * Time.deltaTime);
	}
	
	
}