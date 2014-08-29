using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float movementSpeed = 125;
	public float runningSpeed = 200;
	private Vector3 mouseOrigin;
	private float turnSpeed = 4.0f;
	private float rotationX = 0.0f;
	private float rotationY = 0.0f;
	private float sensitivity = 5f;
	void Start(){
		//Transform.position = new Vector3 (0, 3, 0);
		Screen.lockCursor = !Screen.lockCursor;
	}

	void Update () {
		if(Input.GetMouseButtonDown(1)){
			Screen.lockCursor = !Screen.lockCursor;
		}
		rotationX += Input.GetAxis("Mouse X") * sensitivity;
		rotationY += Input.GetAxis("Mouse Y") * sensitivity;
		rotationY = Mathf.Clamp(rotationY, -40, 40);

		transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);
		transform.localRotation *= Quaternion.AngleAxis(rotationY, Vector3.left);


		if (Input.GetKey ("w")) {
		rigidbody.AddRelativeForce(0, 0,movementSpeed);
		} else {
				rigidbody.velocity = new Vector3 (0, 0, 0);
		}

		if (Input.GetKey ("s")) {
			rigidbody.AddRelativeForce(0,0,-movementSpeed);				
		} else {
			rigidbody.velocity = new Vector3 (0, 0, 0);
		}

		if (Input.GetKey ("d")) {
			rigidbody.AddRelativeForce(movementSpeed,0,0);	
		}

		if (Input.GetKey ("a")) {
			rigidbody.AddRelativeForce(-movementSpeed,0,0);	
		}

		if (Input.GetKey ("q")) {
			rigidbody.AddRelativeForce(-movementSpeed,0,movementSpeed);				
		} else {
			rigidbody.velocity = new Vector3 (0, 0, 0);
		}
		
		if (Input.GetKey ("e")) {
			rigidbody.AddRelativeForce(movementSpeed,0,movementSpeed);				
		} else {
			rigidbody.velocity = new Vector3 (0, 0, 0);
		}
	}
}