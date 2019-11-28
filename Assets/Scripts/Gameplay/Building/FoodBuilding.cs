using System.Collections;
using UnityEngine;

namespace Gameplay.Building
{
    public class FoodBuilding : BuildingScripts
    {
        protected override IEnumerator ResourceLoop()
        {
            while (Active)
            {
                resourceManager.ChangeFoodAmountBy(building.ResourceGenerationAmount);

                yield return new WaitForSeconds(building.CreationTime);
            }
        }
    }
}


