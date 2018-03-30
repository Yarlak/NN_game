using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {


Rigidbody r_body;

Vector3 hit_direction;

float up_mult = 7.0f;
float forward_mult = 20.0f;


	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "score")
		{
			print("goalllllllll");
			Application.LoadLevel(0);
		}
		
		
	}
	
	void OnCollisionEnter(Collision collision)
	{
		
		if (collision.collider.gameObject.tag == "Player")
		{
			hit_direction = transform.position - collision.collider.gameObject.transform.position;
			hit_direction = hit_direction/hit_direction.magnitude;
			r_body.velocity = new Vector3 (hit_direction.x * forward_mult, up_mult, hit_direction.z * forward_mult);
		}
	}


	
	// Use this for initialization
	void Start () 
	{
		
		r_body = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
