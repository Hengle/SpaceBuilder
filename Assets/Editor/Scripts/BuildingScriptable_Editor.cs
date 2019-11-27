using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


[CustomEditor(typeof(BuildingScriptable))]
public class BuildingScriptable_Editor : Editor
{
    private BuildingScriptable buildingScriptable;

    private VisualElement rootElement;
    private VisualTreeAsset visualTreeAsset;

    public void OnEnable()
    {
        buildingScriptable = (BuildingScriptable)target;
        
        rootElement = new VisualElement();

        visualTreeAsset = Resources.Load<VisualTreeAsset>("Bindings/BuildingScriptable_Editor");
        var uxml = visualTreeAsset.CloneTree();

        rootElement.Add(uxml);
        
    }
    

    public override VisualElement CreateInspectorGUI()
    {
        return rootElement;
    }
}