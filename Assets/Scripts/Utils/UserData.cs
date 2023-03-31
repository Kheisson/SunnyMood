using UnityEngine;

public class UserData
{
    #region Public Properties

    public static string CurrentLevel
    {
        get => PlayerPrefs.GetString("CurrentLevel", "Level 1");
        set => PlayerPrefs.SetString("CurrentLevel", value);
    }

    public static int TopLevelReached
    {
        get => PlayerPrefs.GetInt("TopLevelReached", 1);
        set => PlayerPrefs.SetInt("TopLevelReached", value);
    }

    #endregion
}
