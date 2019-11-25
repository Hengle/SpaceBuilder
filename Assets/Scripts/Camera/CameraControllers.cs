using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;



public class CameraControllers : MonoBehaviour
{
    [SerializeField] private bool game = false;
    
    [Header("Components")] 
    [SerializeField] private CameraMovement cameraMovement;
    
    #region Event Handlers

    public void CameraMovement(InputAction.CallbackContext context)
    {
        Vector2 movementDir = context.ReadValue<Vector2>();
        cameraMovement.SetMovementDirection(movementDir);
    }
    
    public void CameraRotation(InputAction.CallbackContext context)
    {
        float rotationDir = context.ReadValue<float>();
        cameraMovement.SetRotationDirection(rotationDir);
    }
    
    public void CameraZoom(InputAction.CallbackContext context)
    {
        float zoomDir = context.ReadValue<float>();
        cameraMovement.SetZoomDirection(zoomDir);
    }

    #endregion

    private void OnValidate()
    {
        if (!cameraMovement)
        {
            cameraMovement = gameObject.GetComponentInChildren<CameraMovement>();
        }
    }


}
