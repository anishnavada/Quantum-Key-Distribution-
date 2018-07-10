using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalKey : MonoBehaviour {

	public GameObject box1;
	public GameObject box2;
	public Text omessage;
	public Text message;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Renderer rend = box1.GetComponent<Renderer> (); 
		Renderer rend2 = box2.GetComponent<Renderer> ();
		if (rend.material.color == rend2.material.color) {
			message.text = omessage.text;
		}
		if (rend.material.color != rend2.material.color) {
			message.text = "";
		}
	}
}
