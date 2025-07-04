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
    public AttacjScript AttackScript;
    public ParameterPlayerScript playerScript;
    public LogicSceneScript logicScript;

    public Animator animator;
    public bool isStriking = false;
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
        // death logic
        if(playerScript.playerIsAlive == false)
        {
            animator.SetBool("isDead", true);
        }

        //Movement axises
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize();

        // Strike logic animation
        isStriking = Input.GetKeyDown(KeyCode.Space);
        if (isStriking == true)
        {
            AttackScript.Attack(AttackScript.DamageAount);
            animator.SetBool("isStriking", true);
        }
        else
        {
            animator.SetBool("isStriking", false);
        }

        if (IsAnimationPlaying("Strike")) 
        {
            movement.x = 0;
            movement.y = 0;
        }

    }

    private void FixedUpdate()
    {
        //Movement
        if (playerScript.playerIsAlive == true)
        {
            rigidBody2D.MovePosition(rigidBody2D.position + movement * moveSpeed * Time.deltaTime);
        } else
        {
            logicScript.Death();
        }

        //Walk animation
        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("isWalking", 1);
            if (movement.x < 0)
            {
                character.transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                character.transform.localScale = new Vector3(1, 1, 1);
            }
        }
        else
        {
            animator.SetFloat("isWalking", 0);
        }
    }

    //Strike return animation name
    public bool IsAnimationPlaying(string animationName) 
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        return stateInfo.IsName(animationName);
    }
}
