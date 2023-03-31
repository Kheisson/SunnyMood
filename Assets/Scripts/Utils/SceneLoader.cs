using UnityEngine.SceneManagement;

public static class SceneLoader
{
    #region Constants

    private const int MainMenuSceneIndex = 0;

    #endregion
    
    
    #region Public Methods

    public static void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void LoadNextScene()
    {
        var currentLevel = SceneManager.GetActiveScene().buildIndex + 1;
        var nextLevel = currentLevel % SceneManager.sceneCountInBuildSettings;
        var topLevelReached = int.Parse(UserData.CurrentLevel.Split(' ')[1]);
        if (nextLevel > topLevelReached)
        {
            UserData.CurrentLevel = $"Level {nextLevel}";
        }
        SceneManager.LoadScene(nextLevel);
    }

    public static void LoadMainMenu()
    {
        SceneManager.LoadScene(MainMenuSceneIndex);
    }
    
    public static void LoadPlayScene()
    {
        SceneManager.LoadScene(UserData.TopLevelReached);
    }
    #endregion
}
