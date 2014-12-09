using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	void OnTriggerExit(Collider other) {
		Debug.Log(other.tag);
		Destroy(other.gameObject);
		if(other.gameObject.transform.parent) Destroy(other.gameObject.transform.parent.gameObject);
	}
}
