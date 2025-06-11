using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using Unity.Mathematics;

public class SkeletonMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rigidBody2D;
    public Transform character;
    private Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody2D = GameObject.FindGameObjectWithTag("MainCharacter").GetComponent<Rigidbody2D>();
        rigidBody2D.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize();
    }

    private void FixedUpdate()
    {
        // rigidBody2D.linearVelocity = movement * moveSpeed * Time.deltaTime;
        //Vector2 movement2 = new Vector2(movement.x, movement.y);
        //transform.Translate(movement2 * moveSpeed * Time.deltaTime);

        //(rigidBody2D.position + movement * moveSpeed * Time.deltaTime);
        rigidBody2D.MovePosition(rigidBody2D.position + movement * moveSpeed * Time.deltaTime);
    }
}
