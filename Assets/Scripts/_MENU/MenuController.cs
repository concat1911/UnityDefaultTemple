// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
	[Header("Settings")]
	public string newgame = "NewGame";

	public void StartGame(){
		SceneManager.LoadScene(newgame);
	}

	public void OpenOptions(){

	}

	public void CloseOption(){

	}

	public void OpenCredits(){

	}

	public void CloseCredits(){

	}

	public void LoadScene(int sceneIndex){
		SceneManager.LoadScene(sceneIndex);
	}

	public void QuitGame(){
		Application.Quit();
	}
}