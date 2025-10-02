using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneEngine : MonoBehaviour
{
    public string[] sceneList;
    public void SaveCurrentScene(int scene)
    {
        PlayerPrefs.SetInt("scene", scene);
        PlayerPrefs.Save();
    }
    public void LoadSaveScene()
    {
        var curScene = PlayerPrefs.GetInt("scene", 0);
        SceneManager.LoadScene("Level_1");
    }
}
