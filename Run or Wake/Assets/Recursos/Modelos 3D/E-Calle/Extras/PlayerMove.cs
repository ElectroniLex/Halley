using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Transform Cam;
    CharacterController control;
    //private float speedCam;
    [SerializeField] private float speedCam;
    [SerializeField] private float camRotation;
    [SerializeField] private float playerSpeed;
    [SerializeField] private float gravityForce;
    [SerializeField] private float jumpForce;
    
    //float camRotation=0f;
    float gravityMove=0f;

    // Start is called before the first frame update
    private void Start()
    {
        Cam=transform.GetChild(0).GetComponent<Transform>();
        Cursor.lockState=CursorLockMode.Locked;
        control=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        float mouseX= Input.GetAxis("Mouse X");
        float mouseY= Input.GetAxis("Mouse Y");

        transform.Rotate(new Vector3(0, mouseX, 0)* speedCam *Time.deltaTime);
        camRotation -= mouseY* speedCam*Time.deltaTime;
        camRotation =Mathf.Clamp(camRotation, -90, 90);

        Cam.localRotation=Quaternion.Euler(new Vector3(camRotation,0,0));

        float moveX=Input.GetAxis("Horizontal");
        float moveZ=Input.GetAxis("Vertical");

        Vector3 movement=(transform.right*moveX + transform.forward*moveZ)*playerSpeed*Time.deltaTime;
        control.Move(movement);

        control.Move(new Vector3(0,gravityMove,0)*Time.deltaTime);
        if(!control.isGrounded)
        {
            gravityMove+=gravityForce;
        }
        else
        {
            gravityMove=0f;
        }

        if(Input.GetKeyDown(KeyCode.Space)&&control.isGrounded)
        {
            gravityMove=jumpForce;
        }

    }

}
