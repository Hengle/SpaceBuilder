using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[Serializable]
public class InputSystemEvent : UnityEvent<InputAction.CallbackContext>
{
}

public class InputManager : Singleton<InputManager>
{
    [Header("Camera Controls")] public InputSystemEvent CameraMovementEvent;

    public InputSystemEvent CameraRotationEvent;
    public InputSystemEvent CameraZoomEvent;

    public InputSystemEvent SelectionEvent;
    public static GameControls GameControls { get; private set; }


    private void OnEnable()
    {
        GameControls = new GameControls();
        GameControls.Enable();

        GameControls.CityBuilding.Movement.performed += CameraMovementEvent.Invoke;
        GameControls.CityBuilding.Rotation.performed += CameraRotationEvent.Invoke;
        GameControls.CityBuilding.Zoom.performed += CameraZoomEvent.Invoke;

        GameControls.CityBuilding.SelectionClick.performed += SelectionEvent.Invoke;
    }

    private void OnDisable()
    {
        GameControls.CityBuilding.Movement.performed -= CameraMovementEvent.Invoke;
        GameControls.CityBuilding.Rotation.performed -= CameraRotationEvent.Invoke;
        GameControls.CityBuilding.Zoom.performed -= CameraZoomEvent.Invoke;

        GameControls.CityBuilding.SelectionClick.performed -= SelectionEvent.Invoke;

        GameControls.Disable();
    } 
}