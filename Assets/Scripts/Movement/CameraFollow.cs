using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothTime = 0.55f;
	private float playerY;
	private float playerZ;
	private Vector3 velocity = Vector3.zero;
	private Vector3 positionPlayer;
	void start(){
		//playerY = target.position.y + 4;
		//playerZ = target.position.z - 3;
		//positionPlayer = new Vector3(-3f ,playerY,playerZ);
	}
	void Update() 
	{

		Vector3 goalPos = target.position;
		goalPos.y = transform.position.y;
		//goalPos.z = transform.position.z -3;
		//goalPos.x = transform.position.x - 3;
		transform.position = Vector3.SmoothDamp(transform.position, goalPos, ref velocity, smoothTime);
	}
}
