using UnityEngine;
using System.Collections;

public class GodMode : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.name == "baseMale") {
			col.gameObject.GetComponent<PlayerScript>().god = true;
			Destroy(gameObject);
		}
	}

	void Update () {
		transform.Rotate(Vector3.up, Time.deltaTime*10);
	}
}
