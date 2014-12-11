using UnityEngine;
using System.Collections;

public class DiePlayerScript : MonoBehaviour {

	public GameObject retryDialog;

	public void Die() {
		retryDialog.SetActive(true);
	}

	// Use this for initialization
	void Start () {
		retryDialog.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
