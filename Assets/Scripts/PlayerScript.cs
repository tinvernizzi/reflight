using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
	private Rigidbody rigidbody;
	
	public float speed = 100f;
	public float tilt;
	public float xMin, xMax;

	void Start ()
	{
		rigidbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		GetComponent<Rigidbody>().velocity = movement * speed;

		GetComponent<Rigidbody>().position = new Vector3
			(
				Mathf.Clamp (GetComponent<Rigidbody>().position.x, xMin, xMax), 
				0.0f, 
				0.0f
			);

		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, GetComponent<Rigidbody>().velocity.x * tilt, 0.0f);
	}

	void OnCollisionEnter(Collision collision) {
		Destroy (this.gameObject);
	}
}
