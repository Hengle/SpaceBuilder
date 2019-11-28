using System.Collections;
using UnityEngine;

namespace Gameplay.Building
{
    public class OreBuilding : BuildingScripts
    {
        protected override IEnumerator ResourceLoop()
        {
            while (Active)
            {
                resourceManager.ChangeOreAmountBy(building.ResourceGenerationAmount);

                yield return new WaitForSeconds(building.CreationTime);
            }
        }
    }
}