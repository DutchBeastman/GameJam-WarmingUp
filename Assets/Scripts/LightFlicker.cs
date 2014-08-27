using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour {
	
	public float fullIntensity = 1f;
	public float flickerPeriod = 1f;
	public float steadyPeriod = 2f;
	
	
	// Update is called once per frame
	void Update () {
		
		float currentIntensity = 0f;
		
		currentIntensity = Mathf.Max (Mathf.Ceil(Mathf.Sin(Time.time/steadyPeriod)),Mathf.Ceil (Mathf.Sin (Time.time/(steadyPeriod*0.333333F))));
		//Creating an irregular on period by max of square waves with asynchronous period.
		
		light.intensity = Mathf.Max (currentIntensity, flicker(Time.time/flickerPeriod))*fullIntensity;
	}
	
	private float flicker(float flickerIn)
	{
		flickerIn = flickerIn - Mathf.Floor(flickerIn); //drop the real part of the number
		flickerIn = (Mathf.Sin(3.0f/flickerIn)*Mathf.Sin(5f/(1-flickerIn)));
		return flickerIn;
		
	}
}