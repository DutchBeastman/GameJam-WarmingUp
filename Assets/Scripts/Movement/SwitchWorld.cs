using UnityEngine;
using System.Collections;

public class SwitchWorld : MonoBehaviour 
{
	private bool bool1 = false;
	private bool bool2 = true;
	
	void Start()
	{

	}

	void Update()
	{
		Debug.Log(bool1);
		Vector3 world1 = new Vector3(0,0.5f,0);
		Vector3 world2 = new Vector3(0,25f,0);

		if(Input.GetKeyDown("v"))
		{
			//gameObject.transform.position = switches;
			if (bool1)
			{
				bool2 = true;
				bool1 = false;

				gameObject.transform.position = world2;

			}

			else if (bool2)
			{
				bool1 = true;
				bool2 = false;

				gameObject.transform.position = world1;

			}
		}
	}

	void OnCollisionEnter()
	{

	}
	
}
