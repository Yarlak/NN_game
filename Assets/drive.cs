using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drive : MonoBehaviour 
{

	bool stop;
	int count;
	
	float rot_speed;
	float move_speed;
	float rot_mult = 2.0f;
	
	Collider player_collider;
	
	Rigidbody r_body;
	
	
	void OnCollisionEnter(Collision collision)
	{
		
		r_body.velocity = Vector3.zero;
		r_body.angularVelocity = Vector3.zero;		
		
	}
	
	
	

	// Use this for initialization
	void Start () 
	{
		player_collider = gameObject.GetComponent<Collider>();
		r_body = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		move_speed = Input.GetAxis("Vertical");
		rot_speed = Input.GetAxis("Horizontal");
		
		transform.Translate(Vector3.forward * move_speed * 0.2f);
		transform.Rotate(0.0f, rot_speed * rot_mult, 0.0f);
		
	}
	
	void FixedUpdate()
	{
		if (r_body.velocity.magnitude > 0.0f)
		{
			r_body.velocity = Vector3.zero;
			r_body.angularVelocity = Vector3.zero;
		}
		
	}
	
}
