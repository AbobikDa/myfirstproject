using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public SceneEngine sceneEngine;
    public int indexScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            sceneEngine.SaveCurrentScene(indexScene);
            sceneEngine.LoadSaveScene();
        }
    }
}
