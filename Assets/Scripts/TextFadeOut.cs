using UnityEngine;
using System.Collections;

public class TextFadeOut : MonoBehaviour {

	private float fadeDuration = 3.0f;

	void Start()
	{
		StartCoroutine(StartFading());
	}

	private IEnumerator StartFading()
	{
		yield return StartCoroutine(Fade(0.0f, 1.0f, fadeDuration));
		yield return StartCoroutine(Fade(1.0f, 0.0f, fadeDuration));
		Destroy(gameObject);
	}
	
	private IEnumerator Fade(float startLevel, float endLevel, float time)
	{
		float speed = 0.75f/time;

		for(float t = 0.0f; t < 1.0f; t += Time.deltaTime * speed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			guiText.font.material.color = new Color(guiText.font.material.color.r,
				guiText.font.material.color.g,
				guiText.font.material.color.b, a);
			yield return 0;
		}
	}
}
