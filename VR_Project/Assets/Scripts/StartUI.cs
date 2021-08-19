using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUI : MonoBehaviour
{
    GameObject start;
    public bool Check_Start = false;
    public bool check;
    public static StartUI _this;

    // Start is called before the first frame update
    void Start()
    {
        StartUI._this = this;
        start = GameObject.FindGameObjectWithTag("Start");
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "tanto" || other.name == "tanto (1)")
        {
            Check_Start = true;
            start.SetActive(false);
            check = true;
        }
    }
}
