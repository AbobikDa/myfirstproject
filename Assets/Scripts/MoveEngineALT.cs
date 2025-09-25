using UnityEngine;

public class MoveEngineALT : MonoBehaviour
{
    [SerializeField] private float speedALT;
    [SerializeField] private float sidewaySpeedALT;
    [SerializeField] private float jumpForceALT;
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
            rb.AddForce(new Vector3(rb.linearVelocity.x, speedALT), ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(rb.linearVelocity.z, sidewaySpeedALT), ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(rb.linearVelocity.z, -sidewaySpeedALT), ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(new Vector3(rb.linearVelocity.y, jumpForceALT), ForceMode.Impulse);
        }
    }
}
