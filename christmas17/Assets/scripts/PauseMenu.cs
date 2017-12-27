using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {

	// Use this for initialization
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	public GameObject audioOn;
	public GameObject audioOff;
	// Update is called once per frame
	void Start()
	{
		SoundState ();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GameIsPaused) {
				Resume();
			} else {
				Pause();
			}
		}
	}
	public void Resume()
	{   pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	public void Pause()
	{
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void LoadSound()
	{
	}

	public void LoadMenu()
	{
		SceneManager.LoadScene ("MainMenu");
		}

	public void QuitGame()
	{
		Application.Quit ();
	}

	public void ToggleSound()
	{
		if (PlayerPrefs.GetInt ("Muted", 0) == 0) {
			PlayerPrefs.SetInt ("Muted", 1);
		} else {
			PlayerPrefs.SetInt ("Muted", 0);
		}
		SoundState ();
	}
	private void SoundState()
	{
		if (PlayerPrefs.GetInt ("Muted", 0) == 0) {
			AudioListener.volume = 1;
			audioOn.SetActive (true);
			audioOff.SetActive (false);
		} else {
			AudioListener.volume = 0;
			audioOn.SetActive (false);
			audioOff.SetActive (true);
		}
	}


}




