using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public float moveSpeed = 2f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(transform.position.y < -4f)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate () {
        rb.MovePosition(rb.position + new Vector2(0f, -moveSpeed * Time.deltaTime));
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
