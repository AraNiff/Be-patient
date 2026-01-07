using UnityEngine;

public class WorldItem : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Item item;

    private void Start()
    {
        spriteRenderer.sprite = item.image;
    }
}
