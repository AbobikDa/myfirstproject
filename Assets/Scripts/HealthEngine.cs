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
        SceneManager.LoadScene("Level_1");
    }
}     
