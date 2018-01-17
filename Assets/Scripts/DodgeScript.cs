using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeScript : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().velocity = -1 * transform.up * speed;
	}

	void OnCollisionEnter(Collision collision) {
		Destroy (this.gameObject);
	}
}
