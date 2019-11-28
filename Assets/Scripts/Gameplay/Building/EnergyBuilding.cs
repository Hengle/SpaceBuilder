using System.Collections;
using UnityEngine;

namespace Gameplay.Building
{
    public class EnergyBuilding : BuildingScripts
    {
        protected override IEnumerator ResourceLoop()
        {
            while (Active)
            {
                resourceManager.ChangeEnergyAmountBy(building.ResourceGenerationAmount);

                yield return new WaitForSeconds(building.CreationTime);
            }
        }
    }
}