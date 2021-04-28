using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score_s : MonoBehaviour
{
    // Start is called before the first frame update
    private int score=0;
    public TextMeshProUGUI Score;
    public int difficulty = 1;
    public GameObject Spawner;

    
    public void IncrementScore()
    {
        score++;
        UpdateScore();
        difficulty = score / 10 +1 ;
        Spawner.GetComponent<Spawner_s>().spawner_rate = (1 - ((float)difficulty / 10.0f)) + 0.1f;
    }

    public void UpdateScore()
    {
        Score.text = score.ToString();
    }

}
