using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santa : MonoBehaviour {

    public GameObject GiftRed;
    public GameObject GiftBlueR;
    public GameObject GiftPos1;
    public GameObject GiftPos2;

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        /*if (Input.GetMouseButtonDown(0))
        {
            throwRight();
        }
        if (Input.GetMouseButtonDown(1))
        {
            throwLeft();

        }*/
    }

    public void throwRight() {
        anim.SetTrigger("R");
        GameObject GiftR = (GameObject)Instantiate(GiftRed);
        GiftR.transform.position = GiftPos1.transform.position;
    }

    public void throwLeft()
    {
        anim.SetTrigger("L");
        GameObject GiftR = (GameObject)Instantiate(GiftBlueR);
        GiftR.transform.position = GiftPos2.transform.position;
    }
}
