using UnityEngine;

public class ObstacleEngine : MonoBehaviour
{
    [SerializeField] private int _damage;

    private void OnCollisionEnter(Collision collision)
    {
        var health = collision.gameObject.GetComponent<HealthEngine>();

        if (health != null) 
        {
            health.TakeDamage(_damage);
        }
    }
}
