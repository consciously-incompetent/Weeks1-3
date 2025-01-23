using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficLightOnOff : MonoBehaviour
{


    public bool inverse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


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
