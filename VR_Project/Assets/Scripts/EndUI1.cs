using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndUI1 : MonoBehaviour
{
    public Text text_score;
    int score;


    // Start is called before the first frame update
    void Start()
    {
        score = EndUI._this.score;
    }

    // Update is called once per frame
    void Update()
    {
        score = EndUI._this.score;

        text_score.text = "Score : " + Mathf.Round(score);
    }
}
