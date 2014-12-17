using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, new Vector3(transform.position.x, 12.0f ,transform.position.z), 1.5f * Time.deltaTime);
	}
}
