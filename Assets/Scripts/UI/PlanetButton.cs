using System;
using System.Collections;
using System.Collections.Generic;
using Systems;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlanetButton : MonoBehaviour
{
    [SerializeField] private PlanetButtonScriptable PlanetInfo;
    // Start is called before the first frame update

    [Header("Components")]
    [SerializeField] private Image buttonImage;
    [SerializeField] private TextMeshProUGUI buttonText;

    public void LoadPlanetScene(string sceneName)
    {
        Settings.Instance.GameState.gameInitialized = true;
        SceneManager.LoadScene(sceneName);
    }

    private void OnValidate()
    {
        if (!PlanetInfo) return;
        
        if (!buttonImage) buttonImage = GetComponentInChildren<Image>();
        if (!buttonText) buttonText = GetComponentInChildren<TextMeshProUGUI>();

        buttonImage.sprite = PlanetInfo.PlanetImage;
        buttonText.text = PlanetInfo.PlanetName;
    }
}