using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{

	public float speed = 10f;
	public float jumpForce = 200f;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float translation = Input.GetAxis("Vertical")* speed * Time.deltaTime;
		float straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		
		transform.Translate(straffe, 0, translation);

		if (Input.GetKeyDown("escape"))
		{
			Cursor.lockState = CursorLockMode.None;
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(Vector3.up * jumpForce);
			print("jump attempt");
		}
	}
}
