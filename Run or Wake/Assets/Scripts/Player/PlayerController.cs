using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    [SerializeField] Rigidbody rb;

    float horizontalInput;
    [SerializeField] private float horizontalMultiplier = 2;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");


    }
}
