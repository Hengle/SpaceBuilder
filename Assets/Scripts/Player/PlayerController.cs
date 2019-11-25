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
        EventSystem.OnBuildingSelected += selectionSystem.BuildingSelected;
    }

    public void ConfirmBuildingSelection()
    {
        Debug.Log("Confirm Selection");
        selectionSystem.ConfirmBuildingSelection();
    }

    private void OnDisable()
    {
        EventSystem.OnBuildingSelected -= selectionSystem.BuildingSelected;
    }


    private void OnValidate()
    {
        selectionSystem = GetComponentInChildren<BuildingSelectionSystem>();
    }


    private void Update()
    {

    }
}