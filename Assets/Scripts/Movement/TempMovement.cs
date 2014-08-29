using UnityEngine;
using System.Collections;

public class TempMovement : MonoBehaviour 
{
	void Update()
	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		this.transform.Translate(new Vector3(0f, 0f, z) * Constants.movementspeed * Time.deltaTime);
		this.transform.Rotate(new Vector3(0f, x, 0f) * Constants.rotationspeed * Time.deltaTime);
		
	}

}