using System;

using UnityEngine;

[SerializeField]
public class Item
{
    [SerializeField] private string name;
    [SerializeField] private ItemType type;
    [SerializeField] private int effectValue;
    [SerializeField] public Sprite icon;

    public string Name => name;
    public ItemType Type => type;
    public int EffectValue => effectValue;
    public Sprite Icon => icon;

    public Item(string name, ItemType type, int effectValue, Sprite icon = null) //constructor 
    {
        this.name = name;
        this.type = type;
        this.effectValue = effectValue;
        this.icon = icon;
    }

    internal void Remove(Item items)
    {
        throw new NotImplementedException();
    }
}
