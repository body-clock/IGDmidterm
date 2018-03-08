using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PainManager : MonoBehaviour
{
	public float pain;
	public float maxPain;
	public float indicationPain;
	public float timeMultiplier;

	public GameObject player;

	public bool isCarrying;

	// Use this for initialization
	void Start ()
	{

		pain = 5;
		maxPain = 145;
		indicationPain = 2.5f;

		timeMultiplier = 2;

	}
	
	// Update is called once per frame
	void Update ()
	{
		gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(pain += Time.deltaTime * timeMultiplier, 26);
		CheckPain();

		if (player.transform.childCount > 0)
		{
			isCarrying = true;
			
			Debug.Log("carrying");
		}
		else
		{
			isCarrying = false;
			Debug.Log("not carrying");
		}
	}

	void CheckPain()
	
	//once pain gets to a ceratin amount, it increses more rapidly, bring it back down with pills
	//pills spawn slower?
	{
		if (pain >= 20)
		{
			timeMultiplier = 4.5f;

			if (Input.GetMouseButtonDown(0) && isCarrying)
			{
				pain -= 3;
			}
		}

		if (pain >= 50)
		{
			timeMultiplier = 7;
			
			if (Input.GetMouseButtonDown(0) && isCarrying)
			{
				pain -= 5;
			}
		}

		if (pain > maxPain)
		{
			pain = maxPain;
		}

		if (pain == maxPain)
		{
			SceneManager.LoadScene("End");
		}
	}


}
