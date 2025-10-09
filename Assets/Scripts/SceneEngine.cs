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
        var curScene = PlayerPrefs.GetInt("scene", 1);
        SceneManager.LoadScene(sceneList[curScene]);
    }
    public void LoadSaveScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneList[sceneIndex]);
    }

    public void ClearSaved()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
    }
}
