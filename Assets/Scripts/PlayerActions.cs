using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour {
	public Light zaklamp;
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
