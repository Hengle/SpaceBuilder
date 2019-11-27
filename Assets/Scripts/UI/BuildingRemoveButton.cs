using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingRemoveButton : MonoBehaviour
{
   public void OnClick()
   {
      EventSystem.OnBuildingRemovalEvent();
   }
}
