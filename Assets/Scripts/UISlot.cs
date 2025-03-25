using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image background;
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI count;

    public void SetItem(Sprite background, Sprite icon, int count)
    {
        this.background.sprite = background;
        this.icon.sprite = icon;
        this.icon.SetNativeSize();

        if (count > 1)
            this.count.text = count.ToString();
    }

    public void RefreshUI()
    {

    }
}
