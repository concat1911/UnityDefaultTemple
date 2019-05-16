//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	[Header("Attributes")]
	public int healthAmount = 2;
	public float translateTime = 200f;
	public float jumpForce = 20f;
	public CapsuleCollider col;
	public LayerMask groundLayer;

	Rigidbody _Rigidbody;

	void Awake(){

	}

	// Use this for initialization
	void Start () {
		_Rigidbody = GetComponent<Rigidbody>();
		col = GetComponent<CapsuleCollider>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis("Horizontal");

		if(horizontal != 0){
			_Rigidbody.AddForce(horizontal * Time.deltaTime * translateTime, 0, 0, ForceMode.VelocityChange);
		}
	}

	bool isGrounded(){
		return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayer);
	}
}
