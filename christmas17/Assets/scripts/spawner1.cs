using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner1 : MonoBehaviour {
	public GameObject[] enemies;
	private float nextSpawn = 3;
	public Transform prefabToSpawn;
	public float spawnRate = 5;
	public float randomDelay = 1;
	float randSpawn;
	int randEnemy;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		


		if (Time.time > nextSpawn) {
			randEnemy = Random.Range (0, 8);
			randSpawn = Random.Range (0, 2);
			Instantiate (enemies[randEnemy], transform.position, Quaternion.identity);
			nextSpawn = Time.time + spawnRate + Random.Range (0, randomDelay) + randSpawn;



		}

	}
}

