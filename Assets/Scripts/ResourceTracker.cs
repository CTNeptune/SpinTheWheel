using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ResourceTracker : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI[] textMeshes;

    public void AddResources(WheelItem winningItem)
    {
        for (int i = 0; i <= textMeshes.Length - 1; i++)
        {
            if((int)winningItem.itemType == i + 1)
            {
                int value;
                int.TryParse(textMeshes[i].text, out value);
                value += winningItem.itemValue;
                textMeshes[i].text = value.ToString();
            }
        }
    }
}
