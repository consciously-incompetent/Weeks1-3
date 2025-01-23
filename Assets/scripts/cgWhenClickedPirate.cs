using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cgWhenClickedPirate : MonoBehaviour
{

    public SpriteRenderer myRender;
    public Sprite Pirate;
    public Sprite knife;
    bool clicked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        if (myRender.bounds.Contains(mouse) && Input.GetMouseButtonDown(0) && !clicked)
        {
            //Debug.Log("check");
            //transform.position = Vector2.one * 3;
            float danger;
            danger = Random.Range(1, 11);
            clicked = true;

            if (danger >= 3)
            {
                myRender.sprite = Pirate;
            }
            else
            {
                myRender.sprite = knife;
            }





        }
    }
}
