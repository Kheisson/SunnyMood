using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectionPanel : MonoBehaviour
{
    #region Private Variables

    [SerializeField] private GameObject levelButtonPrefab;

    #endregion

    #region Private Properties

    private int LevelsPresent => transform.childCount;

    #endregion

    #region Unity Methods

    private void OnEnable()
    {
        LoadButtons();
        DetermineStatusOfButtons();
    }

    #endregion

    #region Private Methods

    private void LoadButtons()
    {
        int buildSceneCount = SceneManager.sceneCountInBuildSettings;

        if (buildSceneCount - 1 == LevelsPresent)
        {
            return;
        }

        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        
        
        for (int gameScene = 1; gameScene < buildSceneCount; gameScene++)
        {
            var level = Instantiate(levelButtonPrefab, transform);
            var buildName = $"Level {gameScene}";
            level.gameObject.name = buildName;
            level.GetComponentInChildren<Text>().text = buildName;
            level.GetComponent<Button>().onClick.AddListener(new UnityAction(() =>
            {
                SceneManager.LoadScene(buildName);
            }));
        }
    }

    private void DetermineStatusOfButtons()
    {
        var currentLevel = UserData.TopLevelReached;
        foreach (Transform child in transform)
        {
            int.TryParse(child.name.Split(' ')[1], out var level);
            child.GetComponent<Button>().interactable = level <= currentLevel;
        }
    }

    #endregion
}
