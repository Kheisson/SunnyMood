using UnityEngine;

public class MainMenu : MonoBehaviour
{
    #region Button Actions

    public void PlayButton()
    {
        SceneLoader.LoadPlayScene();
    }
    
    public void ExitButton()
    {
        Application.Quit();
    }

    #endregion
}
