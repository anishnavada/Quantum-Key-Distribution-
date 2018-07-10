using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class transferElectrons : MonoBehaviour {

	public Button b;
	public Button b1;
	public Button b2;
	public GameObject box;
	Vector3 destination = new Vector3(0.0f, -10.05f, -10.0f);
	Vector3 destination2 = new Vector3 (0.0f, -20.17f, -10.0f);
	Vector3 destination3 = new Vector3 (0.0f, -30.2f, -10.0f);
	Vector3 speed = new Vector3(0.0f, -0.05f, 0.0f);
	public int x;

	void Start () {
		x = 0;
		Renderer r = box.GetComponent<Renderer> ();
		r.material.SetColor("_Color", Color.red);
		Button btn = b.GetComponent<Button> ();
		btn.onClick.AddListener (onClick);
		Button btn1 = b1.GetComponent<Button> ();
		btn1.onClick.AddListener (onClick1);
		Button btn2 = b2.GetComponent<Button> ();
		btn2.onClick.AddListener (onClick1);
	}

	void onClick(){
		Renderer r = box.GetComponent<Renderer> ();
		r.material.SetColor("_Color", Color.green);
	}

	void onClick1(){
		Renderer r = box.GetComponent<Renderer> ();
		r.material.SetColor("_Color", Color.cyan);
	}

	void Update () {
		Renderer r = box.GetComponent<Renderer> ();
		if (transform.position.y <= destination.y && x==0) {
			r.material.SetColor("_Color", Color.blue);
			x = 1;
		}
		if (transform.position.y <= destination2.y && x==1) {
			r.material.SetColor("_Color", Color.blue);
			x = 2;
		}
		if (transform.position.y <= destination3.y && x==2) {
			r.material.SetColor("_Color", Color.blue);
			x = 3;
		}
		if (r.material.color == Color.green || r.material.color == Color.cyan) {
			transform.position = transform.position + speed;
		}
	}
}
