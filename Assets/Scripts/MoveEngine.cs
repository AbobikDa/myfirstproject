using UnityEngine;

public class MoveEngine : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _sidewaySpeed;
    [SerializeField] private float _jumpForce;
    public Rigidbody rb;
    private bool isGrounded;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground") || collision.collider.CompareTag("Obstacle"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Ground") || collision.collider.CompareTag("Obstacle")) 
        {
            isGrounded = false;
        }
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x + (_speed + Time.deltaTime), transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (_sidewaySpeed + Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (_sidewaySpeed + Time.deltaTime));
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(new Vector3(rb.linearVelocity.y, _jumpForce), ForceMode.Impulse);
        }
    }
}