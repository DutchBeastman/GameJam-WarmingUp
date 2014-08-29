using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour 
{

	public GUIStyle BackTex;

	void OnGUI()
	{
		if (GUI.Button(new Rect(900, 620, Constants.buttonWidth, 80), "", BackTex))
		{
			Application.LoadLevel(0);
		}
	
	}
}
