using UnityEngine;
using System.Collections;

public class MuteMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MuteBGM(){
		AudioSource theBGM;
		theBGM = GameObject.Find ("GameMusic").GetComponent<AudioSource> ();
		if (theBGM.mute == false) {
			theBGM.mute = true;
		} else {
			theBGM.mute = false;
		}
	}
}
