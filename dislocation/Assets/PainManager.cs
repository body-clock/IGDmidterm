using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PainManager : MonoBehaviour
{

	public Text painLevelText;
	public GameObject indicatorText;

	public float pain;
	public float maxPain;
	public float indicationPain;
	public float timeMultiplier;

	// Use this for initialization
	void Start ()
	{

		pain = 0;
		maxPain = 5;
		indicationPain = 2.5f;
		timeMultiplier = 4;


	}
	
	// Update is called once per frame
	void Update ()
	{

		pain += Time.deltaTime/timeMultiplier;
		Debug.Log(pain);
		painLevelText.text = pain.ToString("F1");
		
		CheckPainLevel();
		GrabVicodin();

	}

	void CheckPainLevel()
	{

		if (pain >= indicationPain)
		{
			indicatorText.SetActive(true);
		} else if (pain < indicationPain)
		{
			indicatorText.SetActive(false);
		}
		
		if (pain >= maxPain)
		{
			SceneManager.LoadScene("end");
		}

		if (pain < 0)
		{
			SceneManager.LoadScene("end");
		}
		
	}

	void GrabVicodin()
	{
		if (Input.GetMouseButtonDown(0))
		{
			pain -= 1.0f;
			timeMultiplier -= 0.5f;
		}
	}
}
