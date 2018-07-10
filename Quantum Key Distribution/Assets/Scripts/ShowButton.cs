using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButton : MonoBehaviour {

	int n;
	int x;
	bool allShowing1 = false;
	bool allShowing = false;
	public GameObject b; 
	public GameObject b1;

	void Start () {
		b.SetActive (false);
		b1.SetActive (false);
	}

	void checkAll(){
		n = 0;
		GameObject[] b;
		b = GameObject.FindGameObjectsWithTag ("box");
		foreach(GameObject x in b){
			Renderer r = x.GetComponent<Renderer> ();
			if (r.material.color == Color.red) {
				n = n + 1;
			}
		}
		if (n == 0) {
			allShowing = true;
		}				
	}

	void checkAll1(){
		x = 0;
		GameObject[] b;
		b = GameObject.FindGameObjectsWithTag ("spin");
		Vector3 p = new Vector3(10000.0f, 10000.0f, 0.0f);
		foreach(GameObject i in b){
			if (i.transform.localPosition == p) {
				x = x + 1;
			}
		}
		if (x == 0) {
			allShowing1 = true;
		}
		else {
			allShowing1 = false;
		}
	}

	
	// Update is called once per frame
	void Update () {
		checkAll ();
		checkAll1 ();
		if (allShowing) {
			b.SetActive (true);
		} 	
		if (allShowing1) {
			b1.SetActive (true);
		}
		if (!allShowing1) {
			b1.SetActive (false);
		}
	}
}
