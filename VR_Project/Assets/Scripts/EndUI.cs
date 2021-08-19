using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndUI : MonoBehaviour
{
    public float time = 10.0f;
    public Text text_time;
    public Text text_score;
    Sword sword;
    public int score;

    public static EndUI _this;

    // Start is called before the first frame update
    void Start()
    {
        EndUI._this = this;
        sword = FindObjectOfType<Sword>();
    }

    // Update is called once per frame
    void Update()
    {
        if (StartUI._this.check == true)
        {
            time -= Time.deltaTime;
        }

        score = Sword._this.score;
        text_time.text = "Time : " + Mathf.Round(time);
        text_score.text = "Score : " + Mathf.Round(score);
        
        if(time < 0)
        {
            SceneManager.LoadScene("end");
        }
    }
}
