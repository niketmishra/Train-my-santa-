using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {

	// Use this for initialization
	public static bool GameIsOver = false;
	public GameObject GameOverMenuUI;
	public static int live=8;


	// Update is called once per frame
	void Update () {
		//live = CollisionGround.lives;
			if (live<=0) {
			{	
				Over();
			}
		}
	}

	void Over()
	{
		GameOverMenuUI.SetActive (true);
		//Time.timeScale = 0f;
		GameIsOver = true;
	}


	public void Restart()
	{   
		
		GameOverMenuUI.SetActive (false);
		//Time.timeScale = 1f;
		GameIsOver = false;
		//SceneManager.LoadScene ("trying");

	}



	public void LoadMenu()
	{
	}


}
