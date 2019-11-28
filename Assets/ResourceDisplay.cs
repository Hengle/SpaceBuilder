using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceDisplay : MonoBehaviour
{
    //Components
    [Header("Components")] 
    [SerializeField] private TextMeshProUGUI resourceText; 
    // Start is called before the first frame update

    public void SetText(string text)
    {
        resourceText.text = text;
    }

    private void OnValidate()
    {
        if (!resourceText) resourceText = GetComponentInChildren<TextMeshProUGUI>();
    }
}
