using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AdManager.Instance.ShowVideo ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Play()
	{   
		
		SceneManager.LoadSceneAsync ("trying");
		//Time.timeScale = 1f;

	}
}
