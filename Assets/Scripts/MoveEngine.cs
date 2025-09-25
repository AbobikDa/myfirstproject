using UnityEngine;

public class MoveEngine : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float sidewaySpeed;
    [SerializeField] private float jumpForce;
    public Rigidbody rb;
    private bool isGrounded;
    void Start()
    {
        Debug.Log("start");
    }
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
            transform.position = new Vector3(transform.position.x + (speed + Time.deltaTime), transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (sidewaySpeed + Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (sidewaySpeed + Time.deltaTime));
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(new Vector3(rb.linearVelocity.y, jumpForce), ForceMode.Impulse);
        }
    }
}