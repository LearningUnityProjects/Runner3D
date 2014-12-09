using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

	public GameObject[] obj;
	public float platformSize = 15.0f;
	public float z = -5.0f;
	public int numberOfPlatformsToInvoke = 4;

	// Use this for initialization
	void Start () {
		Spawn ();
	}

	void Spawn() {
		for (int i = 0; i < numberOfPlatformsToInvoke; ++i) {
			z += platformSize;
			int range = Random.Range(0,obj.Length);
			Instantiate(obj[range], new Vector3(transform.position.x, transform.position.y, z), obj[range].transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.parent.gameObject.transform.position.z >= (z-(platformSize*3)))
			Spawn ();
	}
}
