using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 15f;
    public float mapWidth = 5f;
    public int lives = 5;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        var newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rb.MovePosition(newPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        lives = Mathf.Clamp(lives - 1, 0, int.MaxValue);
        if(lives == 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
