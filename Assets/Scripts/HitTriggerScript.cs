using UnityEngine;

public class HitTriggerScript : MonoBehaviour
{
    public SpriteRenderer spriteRendererSkeleton;
    public Collider2D boxCollider;
    public float offsetX;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRendererSkeleton = GameObject.FindGameObjectWithTag("MainCharacter").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spriteRendererSkeleton.flipX == true)
        {
            offsetX = -0.13f;
            boxCollider.offset = new Vector2(offsetX, 0);
        }
        else 
        {
            offsetX = 0.13f;
            boxCollider.offset = new Vector2(offsetX, 0);
        }
    }
}
