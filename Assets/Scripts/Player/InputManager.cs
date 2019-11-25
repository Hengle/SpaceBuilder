using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;


[System.Serializable]
public class InputSystemEvent : UnityEvent<InputAction.CallbackContext>
{
    
}
public class InputManager : Singleton<InputManager>
{
    public static GameControls GameControls { get; private set; }
    
    [Header("Camera Controls")]
    public InputSystemEvent CameraMovementEvent;
    public InputSystemEvent CameraRotationEvent;
    public InputSystemEvent CameraZoomEvent;

    public InputSystemEvent SelectionEvent;
    
    
    

    void OnEnable()
    {
        GameControls  = new GameControls();
        GameControls.Enable();
        
        GameControls.CityBuilding.Movement.performed += CameraMovementEvent.Invoke;
        GameControls.CityBuilding.Rotation.performed += CameraRotationEvent.Invoke;
        GameControls.CityBuilding.Zoom.performed += CameraZoomEvent.Invoke;

        GameControls.CityBuilding.SelectionClick.performed += SelectionEvent.Invoke;
        
    }
    
    void OnDisable()
    {
        GameControls.CityBuilding.Movement.performed -= CameraMovementEvent.Invoke;
        GameControls.CityBuilding.Rotation.performed -= CameraRotationEvent.Invoke;
        GameControls.CityBuilding.Zoom.performed -= CameraZoomEvent.Invoke;

        GameControls.CityBuilding.SelectionClick.performed -= SelectionEvent.Invoke;
        
        GameControls.Disable();
    }
}
