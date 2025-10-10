using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private ItemData[] startingItems;

    void Start()
    {
        foreach (ItemData itemData in startingItems)
        {
            Item newItem = new Item(itemData.itemName, itemData.type, itemData.effectValue);
            inventory.AddItem(newItem);
        }
    }
}
