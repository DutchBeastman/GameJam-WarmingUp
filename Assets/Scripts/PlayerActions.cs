﻿using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour {
	public Light zaklamp;

	public float pushPower = 2.0F;
	public static int nrTotalPickups;
	public static int nrOfPickups;


	void Start () {
		nrTotalPickups = GameObject.FindGameObjectsWithTag("Pickup").Length;

		Debug.Log(nrTotalPickups);
	}
	void Update()
	{

		if(Input.GetKeyDown(KeyCode.F))
		{
			if(zaklamp.enabled == false)
			{
				zaklamp.enabled = true;
			}
			else if (zaklamp.enabled == true)
			{
				zaklamp.enabled = false;
			}
		}
	
	}
	void OnControllerColliderHit(ControllerColliderHit hit) {
<<<<<<< HEAD
				if (hit.collider.name == "MoveableObject") {
						Rigidbody body = hit.collider.attachedRigidbody;
						if (body == null || body.isKinematic)
								return;
						return;
=======
		if (hit.collider.name == "MoveableObject") {
			Rigidbody body = hit.collider.attachedRigidbody;
			if (body == null || body.isKinematic)

				return;

>>>>>>> origin/Develop
		
				if (hit.moveDirection.y < -0.3F)
				return;
		
<<<<<<< HEAD
						Vector3 pushDir = new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);
						body.velocity = pushDir * pushPower;
				}
		}
			
=======
				Vector3 pushDir = new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);
				body.velocity = pushDir * pushPower;
		}
	}
>>>>>>> origin/Develop
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Pickup")
		{
			nrOfPickups += 1;
			Destroy(other.gameObject);
			if(nrOfPickups == nrTotalPickups)
			{
				Debug.Log("Proceed...");
			}
		}
	}
}






