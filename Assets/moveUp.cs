using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp : MonoBehaviour
{
    public float speed = 20;
    bool check = false;

    void Update()
    {
        Vector3 temp = transform.position;

        if (temp.y > -0.70f && check == false)
        {
            temp.y -= speed / 100;
            transform.SetPositionAndRotation(temp, transform.rotation);
        }
        if (temp.y < -0.70f)
            check = true;

        if (temp.y < 1.50f && check == true)
        {
            temp.y += speed / 100;
            transform.SetPositionAndRotation(temp, transform.rotation);
            if (temp.y > 1.50f)
                check = false;
        }
    }
}
