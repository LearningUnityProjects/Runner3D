using UnityEngine;
using System.Collections;

public class TerrainSpawnerScript : MonoBehaviour {

	public GameObject[] obj;
	public float platformSize = 15.0f;
	public float z = -5.0f;
	
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	void Spawn() {
		z += platformSize;
		Instantiate(obj[0], new Vector3(transform.position.x-10, transform.position.y, z), Quaternion.identity);
		z += platformSize;
		Instantiate(obj[0], new Vector3(transform.position.x-10, transform.position.y, z), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.parent.gameObject.transform.position.z >= (z-platformSize))
			Spawn ();
	}
}
