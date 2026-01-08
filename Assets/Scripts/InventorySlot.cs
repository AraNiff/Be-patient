using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class InventorySlot : MonoBehaviour, IDropHandler
{
    public Image image;
    public Color selectedColor;
    public Color defaultColor;

    private void Awake()
    {
        Deselect();
    }

    public void Select()
    {
        image.color = selectedColor;
    }

    public void Deselect()
    {
        image.color = defaultColor;
    }

    public void OnDrop(PointerEventData eventData)
    {
        InventoryItem inventoryItem = eventData.pointerDrag.GetComponent<InventoryItem>();
        if (transform.childCount == 0) 
        {
            inventoryItem.parentAfterDrag = transform;
            return;
        }
        Transform existingChild = transform.GetChild(0);
        InventoryItem existingItem = existingChild.GetComponent<InventoryItem>();
        Transform originalParentOfDragged = inventoryItem.parentAfterDrag;
        existingItem.parentAfterDrag = originalParentOfDragged;
        existingItem.transform.SetParent(originalParentOfDragged);
        inventoryItem.parentAfterDrag = transform;
    }
}
