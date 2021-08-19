using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public int score;
    public int count = 0;
    AudioSource audioSource;
    public static Sword _this;


    // Start is called before the first frame update
    void Start()
    {
        Sword._this = this;
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "blueberry(Clone)")
        {
            score += 50;
            Destroy(other.gameObject);
           this.audioSource.Play();
        }


        if (other.gameObject.name == "strawberry(Clone)")
        {
            score += 40;
            Destroy(other.gameObject);
           this.audioSource.Play();
        }
            

        if (other.gameObject.name == "lemon(Clone)")
        {
            score += 30;
            Destroy(other.gameObject);
           this.audioSource.Play();
        }

        if (other.gameObject.name == "orange(Clone)")
        {
            score += 20;
            Destroy(other.gameObject);
           this.audioSource.Play();
        }

        if (other.gameObject.name == "watermelon(Clone)")
        {
            score += 10;
            Destroy(other.gameObject);
           this.audioSource.Play();
        }

        if (other.gameObject.name == "bomb 1(Clone)")
        {
            score -= 100;
            Destroy(other.gameObject);
        }
        
    }
    
}
