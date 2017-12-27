using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionCheck : MonoBehaviour {
	public static int count=0;
	public Text scoreText;
	public Text scoreFinal;
	public AudioSource coin;
//	public float timer = 10f;
	//public int startint = -1;
//	public Text timerSeconds;
	//public GameObject house;
	//MeshRenderer Meshrend_house;
	// Use this for initialization
	void Start ()
			{
		
				count = 0;
//		StartCoroutine (MyFunction ());
//		timerSeconds = GetComponent<Text> ();

	}
//	IEnumerator MyFunction()
//	{

///		while (true) {
	//		if (count == startint) {
	//			SceneManager.LoadScene ("death");
	//		}
	//		startint = count;
	//
//			}


	//		yield return new WaitForSeconds (5);
	//	}




	
	// Update is called once per frame
	void Update () {

		scoreText.text = count.ToString ("0");
		scoreFinal.text = count.ToString("0");
	
		//timerSeconds.text = timer.ToString ("f0");


	

	}



	void OnCollisionEnter2D(Collision2D collision)
	{	
		if (collision.collider.gameObject.layer == LayerMask.NameToLayer ("Gift")) {
			
			count++;
			//Meshrend_house.material.color = Color.red;

			Destroy (collision.gameObject);

		}

			
	}



}

