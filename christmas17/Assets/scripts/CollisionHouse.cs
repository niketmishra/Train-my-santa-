using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHouse : MonoBehaviour {
	///public GameObject house;
	/// public static int val
	public static int val;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		val = House.touch;
		Debug.Log (val);
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		//if (collision.collider.gameObject.layer == LayerMask.NameToLayer ("House")) {
			//if (Meshrend_house.material.color == Color.red) {
				//Debug.Log ("helo");
			//}
			Debug.Log("des");
			if (val <= 0) {
				Debug.Log ("entereD");
				SceneManager.LoadScene ("death");
			//}

			Destroy(collision.gameObject);

		}
}
}
