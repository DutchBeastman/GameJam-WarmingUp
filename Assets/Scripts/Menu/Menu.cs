using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	public GUIStyle PlayTex;
	public GUIStyle ControlsTex;
	public GUIStyle ExitTex;
	
	public GameObject cameraS;
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(560 ,350 ,200,75),"",PlayTex))
		{
			Debug.Log("play!");
			Application.LoadLevel(1);
		}
		
		if(GUI.Button(new Rect(Screen.width /2 - 132.5f ,400 ,Constants.buttonWidth,Constants.buttonHeight),"",ControlsTex))
		{
			Debug.Log("Controls");
			Application.LoadLevel(2);
			
		}

		if (GUI.Button (new Rect (Screen.width / 2 - 132.5f, 500, Constants.buttonWidth, Constants.buttonHeight), "", ExitTex)) 
		{
			Application.Quit();
		}
	}
}
