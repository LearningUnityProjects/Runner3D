using UnityEngine;
using System.Collections;

public class AirplaneScript : MonoBehaviour {

	public GameObject explosio;
	private bool right = false;
	private Vector3 moveDirection = Vector3.zero;
	private float speed = 6.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController controller = GetComponent<CharacterController>();
		if(right)moveDirection = new Vector3(1, 0,0);
		else moveDirection = new Vector3(-1, 0,0);
		controller.Move(moveDirection * Time.deltaTime * speed);
	}
	

	void OnControllerColliderHit(ControllerColliderHit col) {
		CharacterController controller = GetComponent<CharacterController>();
		if (col.gameObject.name == "baseMale") {
			//controller.transform.Rotate(new Vector3(0,180,0));
			GameObject expl = Instantiate (explosio, transform.position, Quaternion.identity) as GameObject;
			Destroy(gameObject); 
			Destroy(expl, 3);
			col.gameObject.GetComponent<DiePlayerScript>().Die();
			Destroy(col.gameObject);
			
		} else {
			right = !right;
			
		}
	}
}
