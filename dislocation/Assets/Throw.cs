using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour {

	public Transform player;
	public Transform playerCam;
	public float throwForce = 10;
	bool hasPlayer = false;
	public bool beingCarried = false;
	public bool touched = false;
	
	void Start()
	{		
		gameObject.transform.position = new Vector3(2.5f,2.5f,0);
	}

	void Update()
	{
		float dist = Vector3.Distance(gameObject.transform.position, player.position);
		if (dist <= 2.5f)
		{
			hasPlayer = true;
		}
		else
		{
			hasPlayer = false;
		}
		if (hasPlayer && Input.GetButtonDown("Use"))
		{
			GetComponent<Rigidbody>().isKinematic = true;
			transform.parent = playerCam;
			beingCarried = true;
		}
		if (beingCarried)
		{
			if (touched)
			{
				GetComponent<Rigidbody>().isKinematic = false;
				transform.parent = null;
				beingCarried = false;
				touched = false;
			}
			if (Input.GetMouseButtonDown(0))
			{
				GetComponent<Rigidbody>().isKinematic = false;
				transform.parent = null;
				beingCarried = false;
				GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);

				gameObject.transform.position = new Vector3(Random.Range(-7,7),2.5f,Random.Range(-7,7));
			}
			else if (Input.GetMouseButtonDown(1))
			{
				GetComponent<Rigidbody>().isKinematic = false;
				transform.parent = null;
				beingCarried = false;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (beingCarried)
		{
			touched = true;
		}
	}
}
