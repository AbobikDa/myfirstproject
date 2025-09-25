using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed; 

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(Vector3.left * (_rotationSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            var player = other.gameObject.GetComponent<PlayerStatList>();

            if (player != null) 
            {
                player.coinCount += 1;
                Destroy(gameObject);
            }
        }
    }
}
