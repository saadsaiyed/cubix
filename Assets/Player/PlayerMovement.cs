using System.Diagnostics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewayForce = 500f;
    public float upwardForce = 5f;

    private bool check1 = false;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Base")
        {
            check1 = false;
            //UnityEngine.Debug.Log("Collision with base");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("a") || Input.GetKey("left"))// Left Hand Force
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d") || Input.GetKey("right"))//Right Hand Force
        { 
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space) && check1 == false) //Jump
        {
            //UnityEngine.Debug.Log("Space pressed");
            rb.AddForce(Vector3.up * upwardForce, ForceMode.Impulse);
            check1 = true;
        }
        if (rb.position.y < -1f)// if the player is fallen from the base.
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        //if (rb.transform.position.y <= 1.01f && rb.transform.position.x >= -11.9f && rb.transform.position.x <= 10.1f)
        //{
        //    check1 = false;
        //}
    }

}
