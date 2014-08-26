using UnityEngine;
using System.Collections;

public class TempMovement : MonoBehaviour {

	public float movementSpeed = 4f;
	public float rotationSpeed = 75f;

	void Update()
	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		this.transform.Translate(new Vector3(0f, 0f, z) * movementSpeed * Time.deltaTime);
		this.transform.Rotate(new Vector3(0f, x, 0f) * rotationSpeed * Time.deltaTime);
	}

}