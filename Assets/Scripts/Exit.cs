using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		if(col.tag == "Exit")
		{
			Application.LoadLevel("Exit");
		}
	}
}
