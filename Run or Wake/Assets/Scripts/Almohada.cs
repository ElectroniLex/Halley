using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Almohada : MonoBehaviour
{
    [SerializeField] float turnSpeed = 90f;
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>() != null)
        {
            Destroy(gameObject);
            return;
            
        }

        //Cheak that the object we collided with is the player
        if (other.gameObject.name != "Player")
        {
            return;
        }

        //Add to the players score

        GameManager.inst.IncrementScore();
        //Destroy this almuhada score
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
