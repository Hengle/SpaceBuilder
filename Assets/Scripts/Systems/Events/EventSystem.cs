using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventSystem
{
    public delegate void BuildingSelectionEvent(BuildingScriptable building);
    public static event BuildingSelectionEvent OnBuildingSelected;
    
    public static event BuildingRemovalSelectionEvent OnBuildingRemoval;
    public delegate void BuildingRemovalSelectionEvent();
    
    public delegate void BuildingEvent(BuildingScripts building);
    
    public static event BuildingEvent OnBuildingPlacement;
    public static event BuildingEvent OnBuildingDeletion;
    
    
    public static void OnBuildingSelectedEvent(BuildingScriptable building)
    {
        OnBuildingSelected?.Invoke(building);
    }

    public static void OnBuildingPlacementEvent(BuildingScripts building)
    {
        OnBuildingPlacement?.Invoke(building);
    }

    public static void OnBuildingRemovalEvent()
    {
        OnBuildingRemoval?.Invoke();
    }

    public static void OnBuildingDeletionEvent(BuildingScripts building)
    {
        OnBuildingDeletion?.Invoke(building);
    }
}
