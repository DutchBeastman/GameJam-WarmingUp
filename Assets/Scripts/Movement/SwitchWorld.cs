using UnityEngine;
using System.Collections;

public class SwitchWorld : MonoBehaviour 
{
	private bool bool1 = false;
	private bool bool2 = true;
	private Vector3 position1;
	private Vector3 position2;

	void Update()
	{



		if(Input.GetKeyDown("v"))
		{
			//gameObject.transform.position = switches;
			if (bool1)
			{
				gameObject.collider.enabled = false;
				position2 = new Vector3(transform.position.x,-0.01999783f,transform.position.z);

				bool2 = true;
				bool1 = false;

				gameObject.transform.position = position2;
				gameObject.collider.enabled = true;

			}

			else if (bool2)
			{
				gameObject.collider.enabled = false;
				position1 = new Vector3(transform.position.x,-26.85854f,transform.position.z);
				bool1 = true;
				bool2 = false;
				gameObject.transform.position = position1;
				gameObject.collider.enabled = true;

			}
		}
	}


	
}