using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class SkeletonMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rigidBody2D;
    private Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody2D = GameObject.FindGameObjectWithTag("MainCharacter").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigidBody2D.MovePosition(rigidBody2D.position + movement * moveSpeed * Time.deltaTime);
    }
}
