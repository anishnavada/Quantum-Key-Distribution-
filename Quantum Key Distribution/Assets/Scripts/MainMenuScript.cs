using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour {

	Vector3 speed = new Vector3(0.0f, -0.05f, 0.0f);
	public GameObject box;

	void Update () {
		Renderer r = box.GetComponent<Renderer> ();
		if (r.material.color == Color.green || r.material.color == Color.cyan) {
			transform.position = transform.position + speed;
		}
	}
}
