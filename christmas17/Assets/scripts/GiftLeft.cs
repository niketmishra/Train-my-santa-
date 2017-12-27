using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftLeft : MonoBehaviour
{

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(-3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        if (transform.position.x > max.y)
        {
            Destroy(gameObject);
        }
    }
}
