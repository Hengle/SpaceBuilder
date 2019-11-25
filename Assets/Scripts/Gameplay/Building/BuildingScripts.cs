using UnityEngine;

public class BuildingScripts : MonoBehaviour
{
    public BuildingScriptable building;
   
    public void ConfirmPlacement()
    {
        EventSystem.OnBuildingPlacementEvent(this);
    }
}