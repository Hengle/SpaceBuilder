using System;
using System.Globalization;
using UnityEngine;

public class StatsDisplayController : MonoBehaviour
{
    [Header("UI Displays")]
    [SerializeField] private ResourceDisplay peopleDisplay;
    [SerializeField] private ResourceDisplay energyDisplay;
    [SerializeField] private ResourceDisplay foodDisplay;
    [SerializeField] private ResourceDisplay oreDisplay;

    [SerializeField] private ResourceManager resourceManager;
    
    
    private void OnEnable()
    {
        ResourceManager.OnPeopleChangeEvent += OnPeopleAmountChange;
        ResourceManager.OnFoodChangeEvent += OnFoodAmountChange;
        ResourceManager.OnEnergyChangeEvent += OnEnergyAmountChange;
        ResourceManager.OnOreChangeEvent += OnOreAmountChange;
    }
    
    private void OnDisable()
    {
        ResourceManager.OnPeopleChangeEvent -= OnPeopleAmountChange;
        ResourceManager.OnFoodChangeEvent -= OnFoodAmountChange;
        ResourceManager.OnEnergyChangeEvent -= OnEnergyAmountChange;
        ResourceManager.OnOreChangeEvent -= OnOreAmountChange;
    }

    private void OnFoodAmountChange(float value)
         {
             foodDisplay.SetText(value.ToString(CultureInfo.InvariantCulture));
         }
    
    private void OnEnergyAmountChange(float value)
    {
        energyDisplay.SetText(value.ToString(CultureInfo.InvariantCulture));
    }
    
    private void OnOreAmountChange(float value)
    {
        oreDisplay.SetText(value.ToString(CultureInfo.InvariantCulture));
    }

    private void OnPeopleAmountChange(float value)
    {
        peopleDisplay.SetText($"{value.ToString(CultureInfo.InvariantCulture)} / { resourceManager.MaxPeopleCount}");
    }

    private void OnValidate()
    {
        if (!resourceManager) resourceManager = FindObjectOfType<ResourceManager>();
    }
}