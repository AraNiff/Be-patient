using UnityEngine;
using UnityEngine.EventSystems;

public class TrashSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        InventoryItem inventoryItem = eventData.pointerDrag.GetComponent<InventoryItem>();
        if (transform.childCount == 0)
        {
            inventoryItem.parentAfterDrag = transform;
            return;
        }
        Transform existingChild = transform.GetChild(0);
        Destroy(existingChild.gameObject);
        inventoryItem.parentAfterDrag = transform;
    }
}
