using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTimer : MonoBehaviour
{

	public float score;
	public Text scoreText;

	// Use this for initialization
	void Start ()
	{
		score = 0;
		scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		scoreText.text = score.ToString("n0");
		score += Time.deltaTime;
	}
}
