using System.Collections;
using System.Collections.Generic;
using Systems;
using UnityEngine;

public class ReturnButton : MonoBehaviour
{
   public void LoadScene(string sceneName)
   {
      Settings.Instance.LoadScene(sceneName);
   }
}
