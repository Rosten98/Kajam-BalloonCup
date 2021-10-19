using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveDirection;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    //    private bool onTheGround = false;
    private bool jumping = false;
    private Rigidbody2D rbPlayer;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxisRaw("Horizontal");
        jumping = Input.GetKeyDown("space");
        if (jumping)
        {
            jumping = false;
            Debug.Log("Jumping");
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rbPlayer.velocity = new Vector2(moveSpeed * moveDirection, rbPlayer.velocity.y);
    }

    void Jump()
    {
        rbPlayer.AddForce(transform.up * jumpForce);
    }
}
