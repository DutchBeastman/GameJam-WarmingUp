using UnityEngine;
using System.Collections;

public class BG : MonoBehaviour
{
	public Texture2D BG1;
	public Texture2D BG2;
	public Texture2D BG3;
	public Texture2D BG4;
	
	private float timer = 16;
	public GameObject backGround;
	void Start()
	{
		/*BG1 = Resources.Load("Assets/ART/Menu/main_menu_light_on")as Texture2D;
		BG2 = Resources.Load("Assets/ART/Menu/main_menu_light_off_1")as Texture2D;
		BG3 = Resources.Load("Assets/ART/Menu/main_menu_light_off_2")as Texture2D;
		BG4 = Resources.Load("Assets/ART/Menu/main_menu_light_off_3")as Texture2D;*/

	}
	void Update()
	{
		timer -= Time.deltaTime;
		Debug.Log(timer);

		if(timer >= 12)
		{
			backGround.renderer.material.mainTexture = BG1;
		}

		if(timer >= 8 && timer < 12)
		{
			backGround.renderer.material.mainTexture = BG2;
		}

		if(timer >= 4 && timer < 8)
		{
			backGround.renderer.material.mainTexture = BG3;
		}

		if(timer <= 4)
		{
			backGround.renderer.material.mainTexture = BG4;
		}

		if (timer <=0)
		{
			timer += 16;
		}
	}


}
