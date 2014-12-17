using UnityEngine;
using System.Collections;

public class AirplaneScript : MonoBehaviour {

	public GameObject explosio;
	private bool right = false;
	private Vector3 moveDirection = Vector3.zero;
	private float speed = 3.0f;
	private Vector3 wayPointPos;
	// Use this for initialization
	void Start () {
		wayPointPos = new Vector3(3, transform.position.y,transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x >= 3) wayPointPos = new Vector3(-3.0f, transform.position.y,transform.position.z);
		else if (transform.position.x <= -3) wayPointPos = new Vector3(3.0f, transform.position.y,transform.position.z);
		transform.position = Vector3.MoveTowards (transform.position, wayPointPos, speed * Time.deltaTime);
	}
	

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name == "baseMale") {
			//controller.transform.Rotate(new Vector3(0,180,0));
			GameObject expl = Instantiate (explosio, transform.position, Quaternion.identity) as GameObject;
			Destroy(gameObject); 
			Destroy(expl, 3);
			if (!col.gameObject.GetComponent<PlayerScript>().god) {
				col.gameObject.GetComponent<PlayerScript>().Die();
				Destroy(col.gameObject);
			}
		} else {
			right = !right;
		}
	}
}
