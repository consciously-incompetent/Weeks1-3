using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class thescore : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TextMeshProUGUI score;
    int scoreval = 0;
    // Start is called before the first frame update
    void Start()
    {
        score.text = scoreval.ToString();
        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            scoreval += 1;
            score.text = scoreval.ToString();
        }

       if(scoreval > 10)
        {
            gameOverScreen.SetActive(true);
        }
    }
}
