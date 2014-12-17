using UnityEngine;
using System.Collections;

public class camerascript : MonoBehaviour {
	public Vector3 posi;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, posi, speed * Time.deltaTime);
	}
}
