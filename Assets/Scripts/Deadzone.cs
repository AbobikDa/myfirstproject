using UnityEngine;

public class Deadzone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var hp = other.gameObject.GetComponent<HealthEngine>();
        hp.Die();
    }
}
