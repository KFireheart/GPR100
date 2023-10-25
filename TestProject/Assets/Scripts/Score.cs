using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreCount;

    int score = 0;

   
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Points: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints()
    {
        score += 1;
        scoreText.text = "Score: " + Mathf.Round(scoreCount);

    }
}
