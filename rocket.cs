using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {
	Rigidbody rg;

	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		ProcessInput ();
		
	}
	public void ProcessInput(){
		if (Input.GetKey (KeyCode.Space)) {
			rg.AddRelativeForce (Vector3.up*20);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(Vector3.forward);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(-Vector3.forward);
		}
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "targetpad") {
			col.gameObject.GetComponent<Renderer>().material.color = Color.red;
		
		} else if (col.gameObject.name == "launchpad")  {
			
		}else if (col.gameObject.name == "targetpad")  {
			
		}
		else if (col.gameObject.name == "wall1")  {

		}
		else if (col.gameObject.name == "wall2")  {

		}
		else   {
			Application.LoadLevel (Application.loadedLevel);
		}
	
	}
}
