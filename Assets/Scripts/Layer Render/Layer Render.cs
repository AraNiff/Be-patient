using UnityEngine;

public class LayerRender : MonoBehaviour
{
    [SerializeField] public float sortMultiplier = 50f;

    private SpriteRenderer spriteRenderer;
    private float lastY = float.MaxValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Mathf.Abs(transform.position.y - lastY) > 0.01f)
        {
            spriteRenderer.sortingOrder = (int)(-transform.position.y * sortMultiplier);
            lastY = transform.position.y;
        }
    }
}
