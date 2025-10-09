using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthEngine : MonoBehaviour
{
    public PlayerStatList player;

    public void TakeDamage(int damage)
    {
        if (player.healthCount > 0)
        {
            player.healthCount -= damage;
        }
        if (player.healthCount <= 0)
        {
            Die(); 
        }
    }

    public void Die()
    {
        var curScene = PlayerPrefs.GetInt("scene", 1);
        SceneManager.LoadScene(curScene);
    }
}     
