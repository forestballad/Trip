using UnityEngine;
using System.Collections;

public class RestartCurrentLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RestartLevel(){
		Application.LoadLevel (Application.loadedLevel);
	}
}
