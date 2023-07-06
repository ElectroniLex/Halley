using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] private float velocidad;

    [SerializeField] private bool izquierda;
    [SerializeField] private bool derecha;


    private CharacterController characterController;
    private Vector3 direction;
    public float forwardSpeed;//Velocidad de avance 

    private int desiredLane = 1;//0:left, 1:middle, 2:right
    public float laneDistance = 4f;//The distance between tow lanes



    private void Start()
    {

        characterController = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void Update()
    {
        direction.z = forwardSpeed;
        if (izquierda == true)
        {
            player.position -= transform.right * velocidad * Time.deltaTime;

        }

        if (derecha == true)
        {
            player.position += transform.right * velocidad * Time.deltaTime;

        }
    }



    public void MovimientoDerecha()
    {
        derecha = true;
    }

    public void MovimientoIzquierda()
    {
        izquierda = true;
    }

    public void Desactivado()
    {
        derecha = false;
        izquierda = false;
    }
}
