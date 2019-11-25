using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Systems
{
    public class Settings : Singleton<Settings>
    {
        private GameState gameState;
        public GameState GameState
        {
            get
            {
                if (!gameState) gameState = ScriptableObject.CreateInstance<GameState>();
                return gameState;
            }

            set => gameState = value;
        }
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
        
        public void QuitGame()
        {
            Application.Quit();
        }
    }
}

public class GameState : ScriptableObject
{
    public bool gameInitialized = false;
}
