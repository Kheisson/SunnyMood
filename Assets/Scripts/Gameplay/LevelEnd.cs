using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class LevelEnd : MonoBehaviour, IInteractable
    {
        #region Public Methods

        public void Interact()
        {
            var currentLevel = SceneManager.GetActiveScene().buildIndex + 1;
            var nextLevel = currentLevel % SceneManager.sceneCountInBuildSettings;
            if(UserData.TopLevelReached < nextLevel)
                UserData.TopLevelReached = nextLevel;
            SceneLoader.LoadNextScene();
        }

        #endregion
    }
}