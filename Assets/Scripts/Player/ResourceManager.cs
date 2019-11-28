using System;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    [SerializeField] private int people = 0;
    [SerializeField] private int maxPeopleCount = 10;
    [SerializeField] private int  food = 0;
    [SerializeField] private int  ore = 0;
    [SerializeField] private int  energy = 0;
    
    public delegate void OnResourceChange(float value);
    public static event OnResourceChange OnPeopleChangeEvent;
    public static event OnResourceChange OnFoodChangeEvent;
    public static event OnResourceChange OnOreChangeEvent;
    public static event OnResourceChange OnEnergyChangeEvent;

    public int People => people;

    public int Food => food;

    public int Ore => ore;

    public int Energy => energy;

    public int MaxPeopleCount => maxPeopleCount;

    private static void OnPeopleChange(float value)
    {
        OnPeopleChangeEvent?.Invoke(value);
    }

    private static void OnFoodChange(float value)
    {
        OnFoodChangeEvent?.Invoke(value);
    }

    private static void OnMinerChange(float value)
    {
        OnOreChangeEvent?.Invoke(value);
    }

    private static void OnEnergyChange(float value)
    {
        OnEnergyChangeEvent?.Invoke(value);
    }

    private void Start()
    {
        ChangeFoodAmountBy(10);
        ChangeEnergyAmountBy(10);
        ChangePeopleAmountBy(10);
        ChangeOreAmountBy(10);
    }
    
    public void IncreasePopulationMaxBy(int value)
    {
        maxPeopleCount += value;
        
        if (people <= 0) people = 0;
        else if (people > maxPeopleCount)
            people = maxPeopleCount;

        OnPeopleChange(people);
    }

    public void ChangePeopleAmountBy(int value)
    {
        people += value;
        if (people <= 0) people = 0;
        else if (people > maxPeopleCount) {
            people = maxPeopleCount;
        }
        
        OnPeopleChange(people);
    }
    
    public void ChangeFoodAmountBy(int value)
    {
        food += value;
        if (food <= 0) food = 0;
        OnFoodChange(food);
    }
    
    public void ChangeOreAmountBy(int value)
    {
        ore += value;
        if (ore <= 0) ore = 0;
        OnMinerChange(ore);
    }
    
    public void ChangeEnergyAmountBy(int value)
    {
        energy += value;
        if (energy <= 0) energy = 0;
        OnEnergyChange(energy);
    }
}