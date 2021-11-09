using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 1f;
    private float jumpForce = 15f;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce);
    }

    public void MoveLeft()
    {
        Vector3 movement = new Vector3(-2f * speed, 0, 0);
        rb.AddForce(movement);
    }

    public void MoveRight()
    {
        Vector3 movement = new Vector3(2f * speed, 0, 0);
        rb.AddForce(movement);
    }

    public void Attack()
    {
        Debug.Log("Attack");
    }
}
