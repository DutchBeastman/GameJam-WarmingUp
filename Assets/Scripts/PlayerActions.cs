using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour {
	public Light zaklamp;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

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
}
