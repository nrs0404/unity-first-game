using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public Rigidbody player;
    public float m_speed, rotatespeed;

    // When the player uses the W or S key, the player will transform forward or backwards because of our player's Rigidbody.
    // The player will move at the speed we give in the float variable.
    // Using Time.deltaTime is important as not using it can cause issues with the character speed
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            player.velocity = transform.forward * m_speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            player.velocity = -transform.forward * m_speed * Time.deltaTime;

        }
    }
    // This part of the script will allow the player to rotate left and right Use void Update() here
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotatespeed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotatespeed * Time.deltaTime, 0);
        }
    }

}
