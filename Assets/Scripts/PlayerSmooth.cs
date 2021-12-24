using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSmooth : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    void Start()
    {
        
    }
    void Update()
    {
        ProcessInputs();   
    }
    private void FixedUpdate()
    {
        Move();
    }
    void ProcessInputs() 
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY);
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
        
    }
}
