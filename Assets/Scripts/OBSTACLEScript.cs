using UnityEngine;
using System.Collections;

public class OBSTACLEScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		Debug.Log ("HE PICAT");
		if (col.gameObject.name == "baseMale") {
			Debug.Log ("HE PICAT AMB EL TIU");
			Destroy(gameObject); 
			col.gameObject.GetComponent<DiePlayerScript>().Die();
			Destroy(col.gameObject);
			
		} 
	}
}
