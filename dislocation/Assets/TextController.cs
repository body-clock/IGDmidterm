using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{

	public float timer = 0;
	public Text storyText;

	void Start()
	{
		timer = 0;
		storyText = GetComponent<Text>();
	}

	void Update()
	{
		timer += Time.deltaTime;
		print(timer);

		if (timer > 4f)
		{
			storyText.text = "My shoulder... Feels out of place...";
		}
		
		if (timer > 8f)
		{
			storyText.text = "I think I may have... DISLOCATED IT.";
		}

		if (timer > 12f)
		{
			storyText.text = "My shoulder, that is.";
		}

		if (timer > 16f)
		{
			SceneManager.LoadScene("cabin");
		}
	}
}
