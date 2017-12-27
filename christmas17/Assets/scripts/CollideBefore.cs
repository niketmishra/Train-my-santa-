using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideBefore : MonoBehaviour {
	public GameObject gobj;
	public int hit;// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.gameObject.layer == LayerMask.NameToLayer ("House")) {
			

		}

		}
}
