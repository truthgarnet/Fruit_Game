using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public int score;
    public int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(score);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "blueberry(Clone)")
        {
            score += 10;
            Destroy(other.gameObject);

        }


        if (other.gameObject.name == "strawberry(Clone)")
        {
            score += 20;
            Destroy(other.gameObject);
        }
            

        if (other.gameObject.name == "lemon(Clone)")
        {
            score += 30;
            Destroy(other.gameObject);
        }

        if (other.gameObject.name == "orange(Clone)")
        {
            score += 40;
            Destroy(other.gameObject);
        }

        if (other.gameObject.name == "watermelon(Clone)")
        {
            score += 50;
            Destroy(other.gameObject);
        }

        if (other.gameObject.name == "Cube6(Clone)")
        {
            score -= 100;
            Destroy(other.gameObject);
        }
        
    }
    
}
