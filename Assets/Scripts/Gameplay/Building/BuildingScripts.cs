using System.Collections;
using UnityEngine;

namespace Gameplay.Building
{
    public abstract class BuildingScripts : MonoBehaviour
    {
        public bool Active = true;
    
        [Header("Building Scriptable Object")]
        public BuildingScriptable building;
    
        protected ResourceManager resourceManager;
    
        public void Initialize(ResourceManager resourceManager)
        {
            this.resourceManager = resourceManager;
            StartResourceLoop();
        }

        public virtual void DestroyBuilding()
        {
   
        }
        
        

        private void StartResourceLoop()
        {
            StartCoroutine(ResourceLoop());
        }

        protected virtual IEnumerator ResourceLoop()
        {
            return null;
        }

        public void ConfirmPlacement()
        {
            EventSystem.OnBuildingPlacementEvent(this);
        }
    }
}