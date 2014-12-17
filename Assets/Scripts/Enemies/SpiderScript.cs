using UnityEngine;
using System.Collections;

public class SpiderScript : MonoBehaviour {

	public GameObject explosio;
	private bool right = false;
	private float speed = 5.0f;
	private Vector3 wayPointPos;
	// Use this for initialization
	void Start () {
		wayPointPos = new Vector3(transform.position.x, transform.position.y, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
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
