using UnityEngine;
using System.Collections;

public class AirplaneScript : MonoBehaviour {

	public GameObject explosio;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		GameObject expl = Instantiate(explosio, transform.position, Quaternion.identity) as GameObject;
		Destroy(gameObject); 
		Destroy(expl, 3);
		col.gameObject.GetComponent<DiePlayerScript>().Die();
	}
}
