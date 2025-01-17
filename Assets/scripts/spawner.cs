using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)) 
        {

            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject looker = Instantiate(prefab,mouse,Quaternion.identity);

            Destroy(looker, 5);
        }



        
    }
}
