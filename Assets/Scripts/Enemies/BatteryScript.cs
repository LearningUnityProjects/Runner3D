using UnityEngine;
using System.Collections;

public class BatteryScript : MonoBehaviour {

	public GameObject explosio;

	void OnTriggerEnter(Collider col) {
		Debug.Log (col.gameObject.name);
		//controller.transform.Rotate(new Vector3(0,180,0));
		GameObject expl = Instantiate (explosio, transform.position, Quaternion.identity) as GameObject;
		Destroy(gameObject); 
		Destroy(expl, 3);
		if (!col.gameObject.GetComponent<PlayerScript>().god) {
			col.gameObject.GetComponent<PlayerScript>().Die();
			Destroy(col.gameObject);
		}
	}
}
