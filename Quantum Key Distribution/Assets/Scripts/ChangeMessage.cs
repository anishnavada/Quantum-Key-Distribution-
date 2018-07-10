using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMessage : MonoBehaviour {

	public GameObject box1;
	public GameObject box2;
	public Text message; 

	void Start () {
		message.text = ""; 
	} 
	
	// Update is called once per frame
	void Update () {
		Renderer rend = box1.GetComponent<Renderer> (); 
		Renderer rend2 = box2.GetComponent<Renderer> ();
		if (rend.material.color == rend2.material.color && rend.material.color == Color.blue) {
			message.text = "Alice and Bob both measured this electron in the x-direction";
		}
		if (rend.material.color == rend2.material.color && rend.material.color == Color.green) {
			message.text = "Alice and Bob both measured this electron in the y-direction";
		}
		if (rend.material.color != rend2.material.color) {
			message.text = "Alice and Bob measured this electron in different directions";
		}
	}
}
