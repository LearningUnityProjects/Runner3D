using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	void OnTriggerExit(Collider other) {
		Debug.Log(other.tag);
		Destroy(other.gameObject);
	}
}
