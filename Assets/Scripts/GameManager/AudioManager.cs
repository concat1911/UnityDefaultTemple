// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	//SINGLETON
	public static AudioManager instance = null;

	//AUDIO SOURCE
	public AudioSource efxSource;
	public AudioSource musicSource;

	//PITCH
	public float lowPitchRange = .95f;
	public float hightPitchRange = 1f;

	void Awake(){
		if(instance == null){
			instance = this;
		}else if(instance != this){
			Destroy(gameObject);
		}
		DontDestroyOnLoad(gameObject); 
	}

	//PLAY ONE TIME
	public void PlaySingle(AudioClip clip){
		efxSource.clip = clip;
		efxSource.Play();
	}

	public void RandomizeSfx(params AudioClip[] clips){
		int randomIndex = Random.Range(0, clips.Length - 1);
		float randomPitch = Random.Range(lowPitchRange, hightPitchRange);

		efxSource.pitch = randomPitch;
		efxSource.clip = clips[randomIndex];
		efxSource.Play();

	}

}
