using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	public GameObject[] obj;
	public float platformSize = 15.0f;
	public float z = -5.0f;

	// Use this for initialization
	void Start () {
		Spawn ();
	}

	void Spawn() {
		z += platformSize;
		Instantiate(obj[Random.Range(0,obj.Length)], new Vector3(transform.position.x, transform.position.y, z), Quaternion.identity);
		z += platformSize;
		Instantiate(obj[Random.Range(0,obj.Length)], new Vector3(transform.position.x, transform.position.y, z), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.parent.gameObject.transform.position.z >= (z-platformSize))
			Spawn ();
	}
}
