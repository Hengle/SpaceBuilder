using UnityEngine;

namespace Gameplay.Building
{
    [CreateAssetMenu(menuName = "Building")]
    public class BuildingScriptable : ScriptableObject
    {
        public string BuildingName;
        public Sprite BuildingSprite;

        public GameObject BuildingPrefab;
    
        public string BuildingType;

        public float CreationTime = 1f;
    
        public int ResourceGenerationAmount = 1;

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
}