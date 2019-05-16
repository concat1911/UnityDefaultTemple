//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ObstacleControl : MonoBehaviour {
	public ObstacleStats _ObstacleStats;
	public Color[] colors;
	Renderer _Renderer;

	void Awake(){
		_Renderer = GetComponent<Renderer>();
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * _ObstacleStats.speed * Time.deltaTime);

		if(transform.position.z  < -52f){
			Obstacle_Pool.instance.ReturnObjectTop(this.gameObject);
		}
	}

	//DEQUEUE
	private void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Player")){
			Obstacle_Pool.instance.ReturnObjectTop(this.gameObject);
			Debug.Log("U got hit!");
			//GAMEOVER

		}
	}

	public void changeColor(){
		_Renderer.material.color = colors[Random.Range(0, colors.Length - 1)];
	}

}
