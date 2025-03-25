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

    public void SetItem(Image background, Image icon, int count)
    {
        this.background = background;
        this.icon = icon;

        if (count > 1)
            this.count.text = count.ToString();
    }

    public void RefreshUI()
    {

    }
}
