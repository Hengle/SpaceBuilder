
//#define DEBUGGING

using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RaycastManager : Singleton<RaycastManager>
{
    [SerializeField] private float maxRaycastDistance = 50f;
    [SerializeField] private int raycastCheckCount = 5;
    
    private Mouse currentMouse;
    private Camera mainCamera;
    
#if DEBUGGING
    private Vector3 hitLocation;
#endif

    // Start is called before the first frame update
    void Start()
    {
        
        currentMouse = Mouse.current;
        mainCamera = Camera.main;
        
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
       
    }

    private void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode loadMode)
    {
        mainCamera = Camera.main;
    }


    // Update is called once per frame
    void Update()
    {
        
#if DEBUGGING
            hitLocation = GetHitPointFromRaycast();
#endif
    }

    private Vector3 GetHitPointFromRaycast()
    {
        Ray ray = mainCamera.ScreenPointToRay(currentMouse.position.ReadValue());
        
        return Physics.Raycast(ray, out var hit, maxRaycastDistance) ? hit.point : Vector3.zero;
    }
    
    
    public GameObject GetGameObjectFromRaycast(LayerMask layerMask)
    {
        return GetGameObjectFromRaycast(layerMask, out var hit);
    }
    
    
    public GameObject GetGameObjectFromRaycast(LayerMask layerMask, out RaycastHit hit)
    {
        Ray ray = mainCamera.ScreenPointToRay(currentMouse.position.ReadValue());
        if (Physics.Raycast(ray, out hit, maxRaycastDistance, layerMask))
        {
            return hit.collider.gameObject;
        }
        return null;
    }
    
    
    public GameObject[] GetGameObjectsFromRaycast(LayerMask layerMask)
    {
        RaycastHit[] hits = new RaycastHit[raycastCheckCount];
        Ray ray = mainCamera.ScreenPointToRay(currentMouse.position.ReadValue());
        var size = Physics.RaycastNonAlloc(ray, hits, maxRaycastDistance, layerMask);
        if (size > 0)
        {
            var linqQuery = from hit in hits
                select hit.collider.gameObject;

            return linqQuery.ToArray();
        }
        return null;
    }

 
#if DEBUGGING
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, hitLocation);
    }
#endif
     
}

