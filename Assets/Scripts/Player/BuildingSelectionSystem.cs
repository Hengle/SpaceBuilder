using UnityEngine;

namespace Player
{
    class BuildingSelectionSystem : MonoBehaviour
    {
    
        //Highlight System
        private GameObject highlightObject;
    
        [SerializeField] private LayerMask displayOutlineLayerMask;
    
        private BuildingScriptable selectedBuilding;
    
        private bool displayBuildingOutline = false;

        public void BuildingSelected(BuildingScriptable building)
        {
            selectedBuilding = building;

            if (displayBuildingOutline) 
                Destroy(highlightObject);
        
            displayBuildingOutline = true;
        }

        public void ConfirmBuildingSelection()
        {
            if (displayBuildingOutline)
            {
                BuildingScripts building = Instantiate(selectedBuilding.BuildingPrefab, 
                    highlightObject.transform.position, Quaternion.identity, this.transform).GetComponent<BuildingScripts>();
                building.ConfirmPlacement();
            
                DisableSelection(true);
            }
        }
    
        private void Update()
        {
            if (!displayBuildingOutline) return;
        
            GameObject highlightTarget =
                RaycastManager.Instance.GetGameObjectFromRaycast(displayOutlineLayerMask, out var hit);
        
            //If Mouse position is possible target
            if (highlightTarget)
            {
                if (!highlightObject)
                {
                    highlightObject = Instantiate(selectedBuilding.BuildingPrefab, hit.point, Quaternion.identity);
                }
                else
                {
                    highlightObject.transform.position = hit.point;
                }
            }
            else
            {
                if (!highlightObject) return;
            
                DisableSelection(true);
            }
        }

        private void DisableSelection(bool destroy)
        {
            displayBuildingOutline = false;

            if (destroy)
                Destroy(highlightObject);
            else
                highlightObject = null;
        }
    }
}