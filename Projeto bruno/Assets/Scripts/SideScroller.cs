using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScroller : MonoBehaviour
{
    public BoxCollider2D colliderr;

    public Rigidbody2D rb;

    public float width;
    public float scrollSpeed = -2f;

    void Start()
    {
        colliderr = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = colliderr.size.x;

        rb.velocity = new Vector2(scrollSpeed, 0);


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <-width)
        {
            Vector2 resetposition = new Vector2(width * 2f, 0);
            transform.position =(Vector2) transform.position + resetposition;
        }
    }
}
