using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public static int scoreCount;
    public Text hiScoreText;
    public static int hiScoreCount;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            hiScoreCount = PlayerPrefs.GetInt("HighScore");
        }   
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreCount > hiScoreCount){
            hiScoreCount = scoreCount;
            PlayerPrefs.SetInt("HighScore", hiScoreCount);
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        hiScoreText.text = "Hi-Score: " + Mathf.Round(hiScoreCount);
        
    }
}
