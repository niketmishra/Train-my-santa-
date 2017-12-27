using UnityEngine;
using System.Collections;
// © 2017 TheFlyingKeyboard
// theflyingkeyboard.net
public class MoveTillPoint : MonoBehaviour {
	public float speed;
	public GameObject pointA;
	public GameObject pointB;
	public bool reverseMove = false;
	private float startTime;
	private float journeyLength;    
	// Use this for initialization
	void Start () {
		startTime = Time.time;
		journeyLength = Vector3.Distance(pointA.transform.position, pointB.transform.position);
	}

	// Update is called once per frame
	void Update () {
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		if (reverseMove)
		{
			//transform.position = Vector3.Lerp(pointB.transform.position, pointA.transform.position, fracJourney);
		}
		else
		{
			transform.position = Vector3.Lerp(pointA.transform.position, pointB.transform.position, fracJourney);
		}
		/*if ((Vector3.Distance(transform.position, pointB.transform.position) == 0.0f || Vector3.Distance(transform.position, pointA.transform.position) == 0.0f)) //Checks if the object has travelled to one of the points
		{
			if (reverseMove)
			{
				reverseMove = false;
			}
			else
			{
				reverseMove = false;
			}
			startTime = Time.time;
		}*/
	} 
}