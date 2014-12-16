using UnityEngine;
using System.Collections;

public class FollowScript : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 wayPointPos = new Vector3(transform.position.x, transform.position.y, player.transform.position.z);
		//Here, the zombie's will follow the waypoint.
		if (player) {
						float speed = player.GetComponent<MovementScript> ().speed;
						transform.position = Vector3.MoveTowards (transform.position, wayPointPos, speed * Time.deltaTime);
				}
	}
}
