using UnityEngine;

public class InventoryDebug : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itemsToPickUp;

    public void PickUpItem(int id)
    {
        bool result = inventoryManager.AddItem(itemsToPickUp[id]);
        if (result)
        {
            Debug.Log("Item added!");
        }
        else
        {
            Debug.Log("Item haven't been added");
        }
    }

    public void GetSelectedItem()
    {
        Item recievedItem = inventoryManager.GetSelectedItem(false);
        if (recievedItem != null)
        {
            Debug.Log("Item recieved");
        }
        else
        {
            Debug.Log("Item have not been recieved");
        }
    }

    public void UseSelectedItem()
    {
        Item recievedItem = inventoryManager.GetSelectedItem(true);
        if (recievedItem != null)
        {
            Debug.Log("Item used");
        }
        else
        {
            Debug.Log("No item used");
        }
    }
}
