using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Pool : MonoBehaviour {
	public static Obstacle_Pool instance;

	//Object in pool
	public GameObject _ostacle;
	
	//Size of the pool
	public int poolSize;

	//List to contain the objects
	private Queue<GameObject> obstacleList;

	private void Awake(){
		//SINGLETON SETTING UP
		if(instance == null){
			instance = this;
		}else if(instance != this){
			Destroy(gameObject);
		}

		//INITIALIZE
		InitalizePool();
	}

	void InitalizePool(){
		obstacleList = new Queue<GameObject>();

		for(int i = 0; i < poolSize; i++){
			GameObject newObstacle = Instantiate(_ostacle);
			obstacleList.Enqueue(newObstacle);
			newObstacle.SetActive(false);
		}
	}

	public GameObject GetObjectFromPool(Vector3 targetPos, Quaternion rotation){

		//LAZY INSTANTIATION IF POOL WAS NOT BIG ENOUGH
		if(obstacleList.Count <= 0){
			GameObject lazyObj = Instantiate(_ostacle);
			lazyObj.name = "Obstacle";
			lazyObj.SetActive(false);
			obstacleList.Enqueue(lazyObj);
		}

		GameObject newObstacle = obstacleList.Dequeue();
		newObstacle.SetActive(true);
		newObstacle.transform.position = targetPos;
		newObstacle.transform.rotation = rotation;

		return newObstacle;
	}

	public void ReturnObjectTop(GameObject go){
		go.SetActive(false);
		obstacleList.Enqueue(go);
	}
}
