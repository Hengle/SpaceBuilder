using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Building")]
public class BuildingScriptable : ScriptableObject
{
    public string BuildingName;
    public Sprite BuildingSprite;

    public GameObject BuildingPrefab;
}
