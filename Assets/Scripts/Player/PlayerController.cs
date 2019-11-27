using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private BuildingSelectionSystem selectionSystem;
    void Start()
    {
        if (!selectionSystem) selectionSystem = selectionSystem = gameObject.AddComponent<BuildingSelectionSystem>();
        
        //Calls whenever a building is selected from the UI.
        EventSystem.OnBuildingSelected += selectionSystem.EnableBuildingSelection;
        EventSystem.OnBuildingRemoval += selectionSystem.EnableBuildingDeletion;
    }

    public void ConfirmSelection()
    {
        Debug.Log("Confirm Selection");
        selectionSystem.ConfirmSelection();
    }

    private void OnDisable()
    {
        EventSystem.OnBuildingSelected -= selectionSystem.EnableBuildingSelection;
    }


    private void OnValidate()
    {
        selectionSystem = GetComponentInChildren<BuildingSelectionSystem>();
    }

    
}