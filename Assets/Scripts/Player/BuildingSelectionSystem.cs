using System;
using UnityEngine;

namespace Player
{
    class BuildingSelectionSystem : MonoBehaviour
    {
        [Header("Selection Masks")]
        [SerializeField] private LayerMask displayOutlineLayerMask;
        [SerializeField] private LayerMask buildingLayerMask;

        private GameObject highlightObject;
        private BuildingScripts destroyBuilding;
        
        private BuildingScriptable selectedBuilding;

        private enum SelectionStates
        {
            Wait,
            DisplayOutline,
            EnableBuildingDeletion,
            ConfirmBuildingDeletion
        }
        
        [Header("Debug")]
        [SerializeField] private SelectionStates selectionState = SelectionStates.Wait;
    
#region Events

        public void ConfirmSelection()
        {
        
            switch (selectionState)
            {
                case SelectionStates.Wait:
                    break;
                case SelectionStates.DisplayOutline:
                    ConfirmBuildingSelection();
                    break;
                case SelectionStates.EnableBuildingDeletion:
                    ConfirmBuildingDeletion();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        
        }

        public void EnableBuildingSelection(BuildingScriptable building)
        {
            selectedBuilding = building;

            if (selectionState == SelectionStates.DisplayOutline) 
                Destroy(highlightObject);
        
            selectionState  = SelectionStates.DisplayOutline;
        }
        
        private void ConfirmBuildingSelection()
        {
            if (selectionState != SelectionStates.DisplayOutline) return;

            BuildingScripts building = Instantiate(selectedBuilding.BuildingPrefab,
                highlightObject.transform.position, Quaternion.identity, this.transform).GetComponent<BuildingScripts>();
            building.ConfirmPlacement();

            DisableSelection(true);
        }
        
        public void EnableBuildingDeletion()
        {
            selectionState = SelectionStates.EnableBuildingDeletion;
        }
        
        public void ConfirmBuildingDeletion()
        {
            EventSystem.OnBuildingDeletionEvent(destroyBuilding);
        }
        
        #endregion
        

        private void Update()
        {

            switch (selectionState)
            {
                case SelectionStates.Wait:
                    break;
                case SelectionStates.DisplayOutline:
                    BuildingOutline();
                    break;
                case SelectionStates.EnableBuildingDeletion:
                    WaitForBuildingDeletion();
                    break;
                case SelectionStates.ConfirmBuildingDeletion:
                    ConfirmBuildingDeletion();
                    break;
                default:
                    break;
            }
        }

        #region Updates
        
        private void BuildingOutline()
        {
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
        
        private void WaitForBuildingDeletion()
        {
            GameObject building =  RaycastManager.Instance.GetGameObjectFromRaycast(buildingLayerMask, out var hit);

            if (!building) return;
            
            BuildingScripts script = building.GetComponentInParent<BuildingScripts>();
            if (script)
            {
                destroyBuilding = script;
            }
        }
        
        #endregion
        
        private void DisableSelection(bool destroy)
        {
            selectionState = SelectionStates.Wait;

            if (destroy)
                Destroy(highlightObject);
            else
                highlightObject = null;
        }
    }
    
   
}