using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 20;
    bool check = false;

    void Update()
    {
        Vector3 temp = transform.position;

        if(temp.x >-7.00f && check == false)
        {
            temp.x -= speed/100;
            transform.SetPositionAndRotation(temp, transform.rotation);
        }
        if (temp.x < -7.00f)
            check = true;

        if (temp.x < 7.00f && check == true)
        {
            temp.x += speed/100;
            transform.SetPositionAndRotation(temp, transform.rotation);
            if (temp.x > 7.00f)
            check = false;
        }
    }
}
