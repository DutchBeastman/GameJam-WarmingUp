/*using UnityEngine;
using System.Collections;

public class ItemTurn : MonoBehaviour 
{

	//public bool worldswitch;

	public bool bool1;
	public bool bool2 = false;
	public bool keyPressed = false;


	public GameObject world1;
	public GameObject world2;
	
	void Update () 
	{
	if(keyPressed == false){
	if (Input.GetKey(KeyCode.V))
		{
		Worldswitch();
		keyPressed = true;
		}
	else{
		keyPressed = false;
		}
	}
	}

	void Worldswitch()
	{
		if(bool1)
		{
			bool2 = true;
			bool1 = false;
			
		}else{
			bool1 = true;
			bool2 = false;
		} 
		world1.SetActive(bool1);
		world2.SetActive(bool2);


	}
	
}*/
