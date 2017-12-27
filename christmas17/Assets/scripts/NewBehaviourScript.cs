using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour {
	public static int newscore=0;
	public Text scoreText;
	public Text highscore;
	// Use this for initialization
	void Start () {

		highscore.text = PlayerPrefs.GetInt("HighScore").ToString("0");
	//	PlayGamesScript.AddScoreToLeaderboard(TRCrescources.leaderboard_best_scores, newscore);
	}
	
	// Update is called once per frame
	void Update () {
		newscore = CollisionCheck.count;
		scoreText.text = newscore.ToString ("0");
		if(newscore > PlayerPrefs.GetInt("HighScore",0))
			{PlayerPrefs.SetInt ("HighScore", newscore);
			highscore.text = newscore.ToString();
		}
		
		AdManager.Instance.ShowBanner ();
	}
	public void restart()
	{	
		SceneManager.LoadScene ("trying");
		AdManager.Instance.ShowVideo ();
	}
	public void home()
	{
		SceneManager.LoadScene ("MainMenu");
		AdManager.Instance.ShowVideo ();
	}
	//public void ShowLeaderboards()
	//{
	//	PlayGamesScript.ShowLeaderboardsUI();
	//}

}
