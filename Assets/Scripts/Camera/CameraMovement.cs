
//#define DEBUGGING

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class that handles all camera movements and rotations.
/// </summary>
public class CameraMovement : MonoBehaviour
{

    [Header("Settings")]
    [SerializeField] private float cameraMovementSpeed = 10f;
    [SerializeField] private float cameraRotationSpeed = 10f;
    [SerializeField] private float zoomSpeed = 10f;
    
    private Vector2 movementDir;
    private float rotationDir;
    private float zoomDir;

    /// <summary>
    /// Sets camera movement direction.
    /// </summary>
    /// <param name="rotationDirection"></param>
    public void SetMovementDirection(Vector2 movementDirection)
    {
        movementDir = movementDirection;
        
#if DEBUGGING
        Debug.Log(movementDir);
#endif
        
    }
    
    /// <summary>
    /// Sets camera rotation direction.
    /// </summary>
    /// <param name="rotationDirection"></param>
    public void SetRotationDirection(float rotationDirection)
    {
        rotationDir = rotationDirection;

#if DEBUGGING
         Debug.Log(rotationDir);
#endif
    }
    
    /// <summary>
    /// Sets camera rotation direction.
    /// </summary>
    /// <param name="rotationDirection"></param>
    public void SetZoomDirection(float zoomDirection)
    {
        zoomDir = zoomDirection;

#if DEBUGGING
         Debug.Log(zoomDir);
#endif
    }
    
    // Updated Camera Movement
    void Update()
    {
        if (movementDir.x != 0 || movementDir.y != 0)
        {
            Vector3 localForward = transform.forward;
            localForward.y = 0;

            Vector3 localRight = transform.right;
            localRight.y = 0;
            
            Vector3 targetDirection = localForward * movementDir.y;
            
            targetDirection += localRight * movementDir.x;
            
            Vector3 newPosition = transform.position + targetDirection; 
            transform.position = Vector3.Lerp(transform.position, newPosition,  cameraMovementSpeed * Time.deltaTime);
        }

        if (rotationDir != 0)
        {
            Quaternion currentRotation = transform.rotation;
            currentRotation.y += rotationDir * cameraRotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up * cameraRotationSpeed * Time.deltaTime * rotationDir, Space.World);
        }

        if (zoomDir != 0)
        {
            Vector3 newPosition = transform.position + transform.forward * zoomDir;
            transform.position = Vector3.Lerp(transform.position, newPosition,  zoomSpeed * Time.deltaTime);
            
        }
        
    }
}
