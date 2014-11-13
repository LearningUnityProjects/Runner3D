using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	public GameObject[] obj;
	public float platformSize = 15.0f;
	public float MAX_TIME = 15.0f;
	private float time;

	// Use this for initialization
	void Start () {
		Spawn ();
		time = MAX_TIME*2.0f;
	}

	void Spawn() {
		Instantiate(obj[Random.Range(0,obj.Length)], transform.position, Quaternion.identity);
		Instantiate(obj[Random.Range(0,obj.Length)], new Vector3(transform.position.x, transform.position.y, transform.position.z+platformSize), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time <= 0.0f) {
			Spawn ();
			time = MAX_TIME;
		}
	}
}
