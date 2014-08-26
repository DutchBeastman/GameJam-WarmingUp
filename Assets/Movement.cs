using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float movementSpeed = 10;
	void Start(){
		//Transform.position = new Vector3 (0, 3, 0);
	}
	void Update () {
		if (Input.GetKey ("w")) {
						rigidbody.AddRelativeForce (0, 100, 0);
				} else {
						rigidbody.velocity = new Vector3 (0, 0, 0);
				}
		if (Input.GetKey ("s")) {
			rigidbody.AddRelativeForce(0,-100,0);				
		} else {
			rigidbody.velocity = new Vector3 (0, 0, 0);
		}
		if (Input.GetKey ("d")) {
			transform.Rotate(0,0,-3);
}
		if (Input.GetKey ("a")) {
			transform.Rotate(0,0,3);
}
}
}