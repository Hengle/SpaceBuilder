using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildingUIIcon : MonoBehaviour
{
    [SerializeField] private BuildingScriptable building;

    [Header("Components")]
    [SerializeField]  private Image buildingImageComponent;
    [SerializeField]  private TextMeshProUGUI buildingNameComponent;
    
    public void OnClick()
    {
        EventSystem.OnBuildingSelectedEvent(building);
    }
    private void OnValidate()
    {
        if (!building) return;
        
        buildingImageComponent.sprite = building.BuildingSprite;
        buildingNameComponent.text = building.BuildingName;
    }
}
