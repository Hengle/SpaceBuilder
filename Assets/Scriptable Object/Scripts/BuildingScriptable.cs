using System;
using System.Collections;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Building")]
public class BuildingScriptable : ScriptableObject
{
    public string BuildingName;
    public Sprite BuildingSprite;

    public GameObject BuildingPrefab;
    
    public string BuildingType;

    public BuildingType buildingType = global::BuildingType.Null;

    private void OnValidate()
    {
        if (string.IsNullOrWhiteSpace(BuildingType)) return;
        
        buildingType = global::BuildingType.FromString(BuildingType);
        if (buildingType == global::BuildingType.Null)
        {
            Debug.LogWarning("Failed to find building type.");
        }
    }
}