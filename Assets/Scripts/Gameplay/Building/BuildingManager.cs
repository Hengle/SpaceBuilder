using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Building;
using UnityEngine;
using UnityEngine.Serialization;

public class BuildingManager : MonoBehaviour
{
   [SerializeField] private  Dictionary<string, List<BuildingScripts>> inGameBuildings = new Dictionary<string, List<BuildingScripts>>();

   [Header("References")]
   [SerializeField] private ResourceManager resourceManager;

   private void Start()
   {
      EventSystem.OnBuildingPlacement += OnBuildingPlacement;
      EventSystem.OnBuildingDeletion += OnBuildingDeletion;
   }

   private void OnBuildingPlacement(BuildingScripts building)
   {
      Debug.Log("Building Placed");
      
      if (!building) return;
      building.Initialize(resourceManager);
      
      string buildingType = building.building.BuildingType;
      if (inGameBuildings.ContainsKey(buildingType))
      {
         inGameBuildings[buildingType].Add(building);
      }
      else
      {
         inGameBuildings.Add(buildingType, new List<BuildingScripts>());
         inGameBuildings[buildingType].Add(building);
      }
   }

   private void OnBuildingDeletion(BuildingScripts building)
   {
      Debug.Log("Building Deleted");
      if (!building) return;
      
      building.DestroyBuilding();

      string buildingType = building.building.BuildingType;
      if (inGameBuildings.ContainsKey(buildingType))
      {
         inGameBuildings[buildingType].Remove(building);
      }
      
      Destroy(building.gameObject);
   }

   private void OnValidate()
   {
     if(!resourceManager) resourceManager = FindObjectOfType<ResourceManager>();
   }
}