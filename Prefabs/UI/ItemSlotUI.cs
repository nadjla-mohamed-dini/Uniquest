using UnityEngine;
using UnityEngine.UI;
using TMPro;         // si tu utilises TextMeshPro
using System;

public class ItemSlotUI : MonoBehaviour
{
    [SerializeField] private Image iconImage;               
    [SerializeField] private TMP_Text nameTextTMP;         
    
    [SerializeField] private Button button;                

    public void Setup(Item item, Action onClick = null)
    {
        if (iconImage != null)
            iconImage.sprite = item.Icon;

        if (nameTextTMP != null)
            nameTextTMP.text = item.Name;

        if (button != null)
        {
            button.onClick.RemoveAllListeners();
            if (onClick != null) button.onClick.AddListener(() => onClick());
        }
    }
}
