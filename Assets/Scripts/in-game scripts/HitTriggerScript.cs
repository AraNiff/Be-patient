using System.Runtime.CompilerServices;
using UnityEngine;

public class HitTriggerScript : MonoBehaviour
{
    public SkeletonMovement skeletonScript;
    public SpriteRenderer spriteRendererSkeleton;
    public Collider2D polygonCollider;
    public int damage = 10;

    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        skeletonScript = GameObject.FindGameObjectWithTag("MainCharacter").GetComponent<SkeletonMovement>();
        spriteRendererSkeleton = GameObject.FindGameObjectWithTag("MainCharacter").GetComponent<SpriteRenderer>();
        animator = GameObject.FindGameObjectWithTag("MainCharacter").GetComponent<Animator>();
        polygonCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (spriteRendererSkeleton.flipX == true)
        {
            polygonCollider.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            polygonCollider.transform.localScale = new Vector3(1, 1, 1);
        }

        //SkeletonColliderDamage
        if (skeletonScript.IsAnimationPlaying("Strike"))
        {
            polygonCollider.enabled = true;
        }
        else
        {
            polygonCollider.enabled = false;
        }
    }
}
