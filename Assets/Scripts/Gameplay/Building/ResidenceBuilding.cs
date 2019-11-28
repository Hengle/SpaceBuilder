using System;
using System.Collections;
using UnityEngine;

namespace Gameplay.Building
{
    public class ResidenceBuilding : BuildingScripts
    {
        [Header("Residence Settings")]
        [SerializeField] private int residentCount = 0;
        [SerializeField] private int maxResidents = 10;
        protected override IEnumerator ResourceLoop()
        {
            resourceManager.IncreasePopulationMaxBy(building.ResourceGenerationAmount);

            while (Active)
            {
                residentCount++;
                resourceManager.ChangePeopleAmountBy(1);
                
                yield return new WaitForSeconds(building.CreationTime);
            }
        }

        public override void DestroyBuilding()
        {
            resourceManager.IncreasePopulationMaxBy(-building.ResourceGenerationAmount);
        }
    }
}