using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventSystem
{
    public delegate void BuildingSelectedEvent(BuildingScriptable building);
    public static event BuildingSelectedEvent OnBuildingSelected;
    
    public delegate void BuildingPlacementEvent(BuildingScripts building);
    public static event BuildingPlacementEvent OnBuildingPlacement;
    
    

    public static void OnBuildingSelectedEvent(BuildingScriptable building)
    {
        OnBuildingSelected?.Invoke(building);
    }

    public static void OnBuildingPlacementEvent(BuildingScripts building)
    {
        OnBuildingPlacement?.Invoke(building);
    }
}
