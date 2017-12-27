using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour {
	public static int touch=0;
	// Use this for initialization
	void Start () {
		touch = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.gameObject.layer == LayerMask.NameToLayer ("Gift")) {
			touch++;

			//Meshrend_house.material.color = Color.red
		}
	}
}
