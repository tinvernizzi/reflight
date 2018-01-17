using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
	private Rigidbody rigidbody;

	public GameObject player;
	public float currentDistance;
	public bool nextHasBeenCreated = false;
	public float speed;

	// Use this for initialization
	void Start ()
	{
		rigidbody = this.GetComponent<Rigidbody> ();
		rigidbody.velocity = -1 * transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update ()
	{
		currentDistance = transform.position.z - player.GetComponent<Transform>().position.z;

		if (currentDistance < -5 && !nextHasBeenCreated)
		{
			var nextRoad = Instantiate(this);
			nextRoad.GetComponent<Transform>().Translate(0, 24, 0);
			nextHasBeenCreated = true;
			Destroy (this.gameObject);
		}
	}
}
