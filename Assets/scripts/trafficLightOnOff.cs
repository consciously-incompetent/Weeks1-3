using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficLightOnOff : MonoBehaviour
{

    // i use this variable to to show which controls the light should 
    // i did this to use less scripts 
    public bool inverse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // if the inverse is true A makes the light turn and D makes it turn of 
        if (inverse)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {

                transform.localScale = Vector3.one * 1;
            }



            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.localScale = Vector3.one * 0;
            }
        }

        //if inverse is not true A makes the light turn of and D makes it turn on 
        // this in combination with 4 different "lights" makes it so when you click A or D the lights will turn from red to green or vise versa 
        if (!inverse)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {

                transform.localScale = Vector3.one * 0;
            }



            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.localScale = Vector3.one * 1;
            }

        }
    }
}
