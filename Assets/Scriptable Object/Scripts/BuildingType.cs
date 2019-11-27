using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BuildingType
{
    public static BuildingType Null { get; } = new BuildingType("Null" , -1);
    public static BuildingType Residence { get; } = new BuildingType("Residence" , 0);
    public static  BuildingType Food { get; } =  new BuildingType("Food", 1);
    public static  BuildingType Miner { get; } = new BuildingType("Miner",2);
    public static  BuildingType Energy { get; } = new BuildingType("Energy",3);
    public static  BuildingType Ship { get; } = new BuildingType("Ship",4);

    public string Type { get; private set; }
    public int Index { get; private set; }

    private BuildingType(string type, int index)
    {
        Type = type;
        Index = index;
    }

    public static IEnumerable<BuildingType> List()
    {
        return new[] {Residence, Food, Miner, Energy, Ship };
    }

    public static BuildingType FromString(string buildingString)
    {
        try
        {
            var result = List().Single(type => string.Equals(type.Type, buildingString, StringComparison.OrdinalIgnoreCase));
            return result;
        }
        catch (InvalidOperationException e)
        {
            return null;
        }
          
            
    }
    
    public static BuildingType FromValue(int value)
    {
       var result = List().Single(type => type.Index == value);
        return result;
    }
}