using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BuildingManager : MonoBehaviour
{
   [SerializeField] private List<BuildingScripts> inGameBuildings = new List<BuildingScripts>();

   private void Start()
   {
      EventSystem.OnBuildingPlacement += OnBuildingPlacement;
   }

   private void OnBuildingPlacement(BuildingScripts building)
   {
      Debug.Log("Building Placed");
      inGameBuildings.Add(building);
   }
}