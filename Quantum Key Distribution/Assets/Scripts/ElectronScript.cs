using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElectronScript : MonoBehaviour {

	public GameObject box1;
	public GameObject box2;
	public GameObject mbox;
	public int d = 2;
	public int s = 2;
	bool onMouse;
	public Text number;
	public Text number1;
	Vector3 speed = new Vector3(0.0f, -0.05f, 0.0f);

	void Start(){
		Renderer rend2 = box2.GetComponent<Renderer> ();
		Renderer rend = box1.GetComponent<Renderer> ();
		rend.material.SetColor ("_Color", Color.red);	
		rend2.material.SetColor ("_Color", Color.red);	
	}

	void OnMouseOver(){
		onMouse = true;
	}

	void OnMouseExit(){
		onMouse = false;
	}

	void checkY(){
		Renderer r = mbox.GetComponent<Renderer> ();
		if (r.material.color == Color.red) {
			if (d != 1) {
				s = Random.Range (0, 2);
				if (s == 0) {
					number.text = "0";
				} 
				if (s == 1) {
					number.text = "1";
				}
				d = 1;	
			}
		}
		if (r.material.color == Color.blue) {
			if (d != 1) {
				s = Random.Range (0, 2);
				if (s == 0) {
					number1.text = "0";
				} 
				if (s == 1) {
					number1.text = "1";
				}
				d = 1;	
			}
			else if (d == 1) {
				number1.text = number.text;
			}
		}
	}

	void checkX(){
		Renderer r = mbox.GetComponent<Renderer> ();
		if (r.material.color == Color.red) {
			if (d != 0) {
				s = Random.Range (0, 2);
				if (s == 0) {
					number.text = "0";
				} 
				if (s == 1) {
					number.text = "1";
				}
				d = 0;	
			}
		}
		if (r.material.color == Color.blue) {
			if (d != 0) {
				s = Random.Range (0, 2);
				if (s == 0) {
					number1.text = "0";
				} 
				if (s == 1) {
					number1.text = "1";
				}
				d = 0;	
			}
			else if (d == 0) {
				number1.text = number.text;
			}
		}
	}

	void changeBox(){
		Renderer rend = box1.GetComponent<Renderer> (); 
		Renderer rend2 = box2.GetComponent<Renderer> ();
		Renderer r = mbox.GetComponent<Renderer> ();
		if (r.material.color == Color.red) {
			if (d == 2) {
				rend.material.SetColor ("_Color", Color.red);	
			}
			if (d == 0) {
				rend.material.SetColor ("_Color", Color.blue);	
			}
			if (d == 1) {
				rend.material.SetColor ("_Color", Color.green);	
			}
		}
		if (r.material.color == Color.blue) {
			if (d == 2) {
				rend2.material.SetColor ("_Color", Color.red);	
			}
			if (d == 0) {
				rend2.material.SetColor ("_Color", Color.blue);	
			}
			if (d == 1) {
				rend2.material.SetColor ("_Color", Color.green);	
			}
		}
	}

	void Update () {
		Renderer r = mbox.GetComponent<Renderer> ();
		changeBox ();
		if (onMouse && Input.GetKeyDown (KeyCode.Y)) {
			checkY ();
		}
		if (onMouse && Input.GetKeyDown (KeyCode.X)) {
			checkX ();
		}
		if (r.material.color == Color.green) {
			transform.position = transform.position + speed;
		}
	}

}
