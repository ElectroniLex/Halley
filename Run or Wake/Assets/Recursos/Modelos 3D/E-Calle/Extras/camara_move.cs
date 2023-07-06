using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara_move : MonoBehaviour
{
    private new Rigidbody rigidbody;

    public float movementSpeed;
    public Vector2 sensitivity;
    public new Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void UpdateMovement()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Vector3 velocity = Vector3.zero;

        if (hor != 0 || ver != 0)
        {
            Vector3 direction = (transform.forward * ver + transform.right * hor).normalized;

            velocity = direction * movementSpeed;
        }

        velocity.y = rigidbody.velocity.y;
        rigidbody.velocity = velocity;
    }

    private void UpdateMouseLook()
    {
        float hor = Input.GetAxis("Mouse Y");
        float ver = Input.GetAxis("Mouse X");

        if (hor != 0)
        {
            transform.Rotate(0, hor * sensitivity.x, 0);
        }

        if (ver != 0)
        {
            Vector3 rotation = camera.localEulerAngles;
            rotation.x = (rotation.x - ver * sensitivity.y + 360) % 360;
            if (rotation.x > 80 && rotation.x < 180) { rotation.x = 80; }
            else
            if (rotation.x < 280 && rotation.x > 180) { rotation.x = 280; }

            camera.localEulerAngles = rotation;
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        UpdateMouseLook();
    }
}
