using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LERPcarMovementRight : MonoBehaviour
{
    public AnimationCurve curve;
    float t;
    public bool drive;
    public Vector2 start;
    public Vector2 end;
    public float speed = 1;
    public float limit;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {

            drive = false;

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            drive = true;
        }



        if (drive)
        {
            t += speed * Time.deltaTime;
            if (transform.position.y >= limit)
            {
                t = 0;
            }
        }





        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));
    }
}
