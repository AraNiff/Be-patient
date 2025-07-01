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
    public SpriteRenderer spriteRenderer;

    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody2D = GameObject.FindGameObjectWithTag("MainCharacter").GetComponent<Rigidbody2D>();
        rigidBody2D.freezeRotation = true;

        animator = GetComponent<Animator>();
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
        rigidBody2D.MovePosition(rigidBody2D.position + movement * moveSpeed * Time.deltaTime);
        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("isWalking", 1);
            if (movement.x < 0)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }
        }
        else
        {
            animator.SetFloat("isWalking", 0);
        }
    }
}
