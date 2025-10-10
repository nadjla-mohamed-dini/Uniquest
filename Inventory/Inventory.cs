using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Item> items = new List<Item>();

    public List<Item> Items => items;

    public void RemoveItem(Item item)
    {
        if (items.Contains(item)) //  vérifier dans la liste
        {
            items.Remove(item);
            Debug.Log($"Removed: {item.Name}");
        }
        else
        {
            Debug.LogWarning($"{item.Name} not in inventory!");
        }
    }
    public void AddItem(Item item)
    {
        items.Add(item);
        Debug.Log($"add : {item.Name}");
    }
    public void UseItem(Item item, Character target)
    {
        if (!items.Contains(item))
        {
            Debug.LogWarning($"{item.Name} is not in the inventory");
            return;
        }
        switch (item.Type)
        {
            case ItemType.Potion:
                target.Heal(item.EffectValue);
                Debug.Log($"{target.Name} use a potion a regain {item.EffectValue} HP!");
                RemoveItem(item);
                break;

            case ItemType.Key:
                Debug.Log($"{item.Name} is a key");
                break;

            case ItemType.Boost:
                target.ModifyAttack(item.EffectValue);
                Debug.Log($"{target.Name} use {item.Name} and gain {item.EffectValue} Attack");
                RemoveItem(item);
                break;
                
            default:
                break;
            
        }
    }
}
