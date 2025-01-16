using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float tankSpeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 tankPos = transform.position;

        tankPos.x += Input.GetAxis("Horizontal") * tankSpeed * Time.deltaTime;

        transform.position = tankPos;
    }
}
