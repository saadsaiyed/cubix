using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Rigidbody rb;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Object") 
        {
            rb.freezeRotation = false;
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
