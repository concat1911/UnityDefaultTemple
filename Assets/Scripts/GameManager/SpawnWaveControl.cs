//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class SpawnWaveControl : MonoBehaviour {
	//SINGLETON
	public static SpawnWaveControl instance;

	//STATS
	[Header("Attributes")]
	public Obstacle_Pool _Obstacle_Pool;
	public float timeBetweenSpawner;
	public Transform spawnPoint;

	//PRIVATE
	float timer;

	void Awake(){
		//SINGLETON SETTING UP
		if(instance == null){
			instance = this;
		}else if(instance != this){
			Destroy(gameObject);
		}
	}

	void Update(){
		if(timer > timeBetweenSpawner){
			//Get Obstacle From Pool
			GameObject obstacleObj = _Obstacle_Pool.GetObjectFromPool(spawnPoint.position, spawnPoint.rotation);

			//Change Random Position
			obstacleObj.transform.position = new Vector3(Random.Range(-16.5f ,16.5f), obstacleObj.transform.position.y, obstacleObj.transform.position.z);

			//Change Random x scale
			obstacleObj.transform.localScale = new Vector3(Random.Range(3.2f, 7f), 2.26f, 0.93f);

			//Change color
			//obstacleObj.GetComponent<ObstacleControl>().changeColor();

			//Reset timer
			timer = 0;
		}

		//TIMER RUNNING
		timer += Time.deltaTime;
	}
}
