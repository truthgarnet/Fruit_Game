using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15.0f);
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + Vector3.back * 0.12f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "tanto")
        {
            this.audioSource.Play();
        }
    }
}
