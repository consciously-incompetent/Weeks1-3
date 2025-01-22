using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LERPcarMovement : MonoBehaviour
{
    public float t;
    public Vector2 start;
    public Vector2 end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += 1 * Time.deltaTime;
        if (transform.position.y <= -6) 
        {
            t = 0;
        }
        transform.position = Vector2.Lerp(start, end, t);
    }
}
