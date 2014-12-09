using UnityEngine;
using System.Collections;

public class FadeTerrain : MonoBehaviour {

	private Color colorStart;
	private Color colorEnd;
	public float duration = 5.0f;

	void onEnable() {
		colorStart = renderer.material.color;
		colorEnd = new Color(colorStart.r, colorStart.g, colorStart.b, 0.0f);
		FadeOut();
	}

	void FadeOut ()
	{
		for (float t = 0.0f; t < duration; t += Time.deltaTime) {
			renderer.material.color = Color.Lerp (colorStart, colorEnd, t/duration);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
