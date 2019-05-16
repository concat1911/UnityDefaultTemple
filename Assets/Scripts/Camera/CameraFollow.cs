//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject _Player;
	public float followSpeed;

	void LateUpdate(){
		transform.position =  Vector3.Lerp(transform.position, _Player.transform.position, Time.deltaTime * followSpeed);
	}
}
