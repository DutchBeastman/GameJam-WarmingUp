using UnityEngine;
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
		if (hit.collider.tag == "MoveableObject") {
			Rigidbody body = hit.collider.attachedRigidbody;
			if (body == null || body.isKinematic)

				return;


		
				if (hit.moveDirection.y < -0.3F)
				return;
				Vector3 pushDir = new Vector3 (hit.moveDirection.x, 0, hit.moveDirection.z);
				body.velocity = pushDir * pushPower;
				}
	}
			
	void OnTriggerEnter(Collider coll)
	{
		if(nrOfPickups == nrTotalPickups)
		{
			
			
		
			if(coll.tag == "Exit")
			{
				Application.LoadLevel("Exit");
			}
		}

		
		if(coll.tag == "Pickup")
		{
			Debug.Log("jkldsfa");
			nrOfPickups += 1;
			Destroy(coll.gameObject);

		}
	}
}






