using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionGround : MonoBehaviour {
	public static int lives=7;
	public GameObject heart3;
	public GameObject heart2;
	public GameObject heart1;
	// Use this for initialization
	void Start () {
		heart1.SetActive (true);
		heart2.SetActive (true);
		heart3.SetActive (true);
	}

	// Update is called once per frame
	void Update(){

		dothis ();
	
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.gameObject.layer == LayerMask.NameToLayer ("Gift")) {
			lives--;
			Destroy (collision.gameObject);
			AdManager.Instance.ShowVideo ();
		}
	}

	void dothis()
	{
		print (lives);

		if (lives <= 5) {
			heart3.SetActive (false);
		}

		if (lives <= 2) {
			heart2.SetActive (false);
		}
		if (lives <= 0) {
			heart1.SetActive (false);
			lives = 7;
			SceneManager.LoadSceneAsync ("death");
		}



	}
}
