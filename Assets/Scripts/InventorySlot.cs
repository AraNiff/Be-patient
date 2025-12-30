using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class InventorySlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0) {
            InventoryItem invetoryItem = eventData.pointerDrag.GetComponent<InventoryItem>();
            invetoryItem.parentAfterDrag = transform;
        }
    }
}
