using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spinMovement : MonoBehaviour {

	public GameObject box;
	public GameObject box2;
	public GameObject mbox;
	public Text number;
	public Vector3 up= new Vector3(-7.48f, 0.97f, 0.0f); 
	public Vector3 down= new Vector3(-7.48f, -0.91f, 0.0f); 
	public Vector3 left= new Vector3(-8.42f, 0.0f, 0.0f); 
	public Vector3 right= new Vector3(-6.54f, 0.0f, 0.0f); 
	public Text number1;


	void Start(){
		
	}

	void changeLocation(){
		Renderer rend = box.GetComponent<Renderer> ();
		Renderer rend1 = box2.GetComponent<Renderer> ();
		Renderer r = mbox.GetComponent<Renderer> ();
		if (r.material.color == Color.red) {
			if (rend.material.color == Color.red) {
				transform.localPosition = new Vector3 (10000.0f, 10000.0f, 0.0f);
			}
			if (rend.material.color == Color.blue && number.text == "1") { 
				Vector3 ptemp = transform.position;
				ptemp.x = -6.54f;
				ptemp.y = 0.0f;
				transform.localPosition = ptemp;   
				Vector3 rtemp = transform.rotation.eulerAngles;
				rtemp.z = 90.0f;
				transform.rotation = Quaternion.Euler (rtemp);
			}
			if (rend.material.color == Color.blue && number.text == "0") { 
				Vector3 ptemp = transform.position;
				ptemp.x = -8.42f;
				ptemp.y = 0.0f;
				transform.localPosition = ptemp;
				Vector3 rtemp = transform.rotation.eulerAngles;
				rtemp.z = 90.0f;
				transform.rotation = Quaternion.Euler (rtemp);
			}
			if (rend.material.color == Color.green && number.text == "1") { 
				Vector3 ptemp = transform.position;
				ptemp.x = -7.48f;
				ptemp.y = 0.97f;
				transform.localPosition = ptemp;
				Vector3 rtemp = transform.rotation.eulerAngles;
				rtemp.z = 0.0f;
				transform.rotation = Quaternion.Euler (rtemp);
			}
			if (rend.material.color == Color.green && number.text == "0") { 
				Vector3 ptemp = transform.position;
				ptemp.x = -7.48f;
				ptemp.y = -0.91f;
				transform.localPosition = ptemp;
				Vector3 rtemp = transform.rotation.eulerAngles;
				rtemp.z = 0.0f;
				transform.rotation = Quaternion.Euler (rtemp);
			}
		}
		if (r.material.color == Color.green) {
			transform.localPosition = new Vector3 (10000.0f, 10000.0f, 0.0f);
		}
		if (r.material.color == Color.blue) {
			if (rend1.material.color == Color.red) {
				transform.localPosition = new Vector3 (10000.0f, 10000.0f, 0.0f);
			}
			if (rend1.material.color == Color.blue && number1.text == "1") { 
				Vector3 ptemp = transform.position;
				ptemp.x = -6.54f;
				ptemp.y = -10.0f;
				transform.localPosition = ptemp;   
				Vector3 rtemp = transform.rotation.eulerAngles;
				rtemp.z = 90.0f;
				transform.rotation = Quaternion.Euler (rtemp);
			}
			if (rend1.material.color == Color.blue && number1.text == "0") { 
				Vector3 ptemp = transform.position;
				ptemp.x = -8.42f;
				ptemp.y = -10.0f;
				transform.localPosition = ptemp;
				Vector3 rtemp = transform.rotation.eulerAngles;
				rtemp.z = 90.0f;
				transform.rotation = Quaternion.Euler (rtemp);
			}
			if (rend1.material.color == Color.green && number1.text == "1") { 
				Vector3 ptemp = transform.position;
				ptemp.x = -7.48f;
				ptemp.y = -9.03f;
				transform.localPosition = ptemp;
				Vector3 rtemp = transform.rotation.eulerAngles;
				rtemp.z = 0.0f;
				transform.rotation = Quaternion.Euler (rtemp);
			}
			if (rend1.material.color == Color.green && number1.text == "0") { 
				Vector3 ptemp = transform.position;
				ptemp.x = -7.48f;
				ptemp.y = -10.91f;
				transform.localPosition = ptemp;
				Vector3 rtemp = transform.rotation.eulerAngles;
				rtemp.z = 0.0f;
				transform.rotation = Quaternion.Euler (rtemp);
			}
		}
	}

	void Update () {
		changeLocation ();

	}
}
