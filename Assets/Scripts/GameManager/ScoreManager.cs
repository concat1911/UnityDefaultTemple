//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

	private static ScoreManager instance;

	public static ScoreManager Instance{
		get{
			//if(instance == null){
			//	GameObject newGO = new GameObject("ScoreManager");
			//	ScoreManager component = newGO.AddComponent<ScoreManager>();
			//	instance = component;
			//}

			return instance;
		}
	}

	float score;
	public TextMeshProUGUI scoreText;

	void Awake(){
		if(instance == null){
			instance = this;
			//This gameObject is no longer destroyed when another level load.
			//DontDestroyOnLoad(gameObject);
		}else{
			Destroy(gameObject);
		}
	}
	void Update(){
		score += Time.deltaTime;
		scoreUpdate();
	}

	//UPDATE SCORE
	void scoreUpdate(){
		scoreText.text = score.ToString("F1") + " m";
	}
}
