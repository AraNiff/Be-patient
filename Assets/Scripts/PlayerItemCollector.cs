using UnityEngine;

public class PlayerItemCollector : MonoBehaviour
{
    public InventoryManager inventoryManager;
    private Collider2D playerCollider;
    public void Start()
    {
        playerCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            WorldItem item = collision.GetComponent<WorldItem>();
            if (item != null)
            {
                bool itemAdded = inventoryManager.AddItem(item.item);
                if (itemAdded)
                {
                    Destroy(collision.gameObject);
                }
            }
        }
    }
}
