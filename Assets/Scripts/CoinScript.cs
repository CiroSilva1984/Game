using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Runs when triggers collision with another 2D object
    private void OnTriggerEnter2D(Collider2D collision)
    {       
        Destroy(gameObject);
        score += 10;        
    }
}
