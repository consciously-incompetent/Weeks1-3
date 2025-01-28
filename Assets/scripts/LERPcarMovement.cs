using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LERPcarMovement : MonoBehaviour
{
    // a lot of public varaibles so that i wouldnt have to make multiple scripts for each car and could instead change the scipts depending on which car its attached to 
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
        // nothing in start 
    }

    // Update is called once per frame
    void Update()
    {
        //unlike what i did with the variables i ended up making two scripts for the left and right cars so clicking A in this sets drive to true but in the other script it sets it to false 
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            // when this variable is set to true the card drives 
            drive = true;
        
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //see above 
            drive = false;
        }



        if (drive)
        {
            //this increments the t(roughly its posisition) variable by the cars speed(and delta time). this it to allow to move fowrad at a specific rate that i can change 
            t += speed * Time.deltaTime;
            if (transform.position.y <= limit)
            {
                //T gets recet when it reaches a designated value 
                //this make the cars look like theri looping of screen 
                t = 0;
            }
        }




        //puts it all together by lerping the car with its designated start and end point by its curve 
        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));
    }
}
