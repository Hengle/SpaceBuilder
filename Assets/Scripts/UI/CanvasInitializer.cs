using System.Collections;
using System.Collections.Generic;
using Systems;
using UnityEngine;

public class CanvasInitializer : MonoBehaviour
{

    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject planetSelectMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Settings.Instance.GameState.gameInitialized)
        {
            planetSelectMenu.SetActive(true);
            startMenu.SetActive(false);
        }
        else
        {
            planetSelectMenu.SetActive(false);
            startMenu.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
