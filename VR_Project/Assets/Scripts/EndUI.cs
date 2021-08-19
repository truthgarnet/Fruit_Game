using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndUI : MonoBehaviour
{
    public float time = 60.0f;
    public Text text_time;
    public Text text_score;
    Sword sword;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        sword = FindObjectOfType<Sword>();
    }

    // Update is called once per frame
    void Update()
    {
        score = sword.score;
        time -= Time.deltaTime;
        text_time.text = "Time : " + Mathf.Round(time);
        text_score.text = "Score : " + Mathf.Round(score);

    }
}
