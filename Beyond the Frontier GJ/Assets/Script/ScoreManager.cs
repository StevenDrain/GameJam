using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
   public void IncrementScore()
    {
        score++;
    }
    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = "Score: " + score;
    }
}
