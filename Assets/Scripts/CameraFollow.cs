using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothTime = 0.25f;

	private Vector3 velocity = Vector3.zero;
	
	void Update() 
	{
		Vector3 goalPos = target.position;
		goalPos.y = transform.position.y;
		transform.position = Vector3.SmoothDamp(transform.position, goalPos, ref velocity, smoothTime);
	}
}
